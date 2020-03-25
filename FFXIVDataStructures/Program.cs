using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace FFXIVDataStructures
{
    class Program
    {
        static async void Main(string[] _)
        {
            Console.WriteLine("Exporting...");

            HttpClient http = new HttpClient();
            Dictionary<string, string> urls = new Dictionary<string, string>
            {
                { "ServerZoneDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Zone/ServerZoneDef.h" },
                { "ClientZoneDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Zone/ClientZoneDef.h" },
                { "ServerLobbyDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Lobby/ServerLobbyDef.h" },
                { "ClientLobbyDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Lobby/ClientLobbyDef.h" },
                { "ServerChatDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Chat/ServerChatDef.h" },
                { "ClientChatDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Chat/ClientChatDef.h" },
            };
            Regex splitLines = new Regex(@"\r\n", RegexOptions.Compiled);
            Regex splitSpaces = new Regex(@" ", RegexOptions.Compiled);
            var output = new Dictionary<string, IDictionary<string, IList<FieldEntry>>>
            {
                { "ServerZoneDef", new Dictionary<string, IList<FieldEntry>>() },
                { "ClientZoneDef", new Dictionary<string, IList<FieldEntry>>() },
                { "ServerLobbyDef", new Dictionary<string, IList<FieldEntry>>() },
                { "ClientLobbyDef", new Dictionary<string, IList<FieldEntry>>() },
                { "ServerChatDef", new Dictionary<string, IList<FieldEntry>>() },
                { "ClientChatDef", new Dictionary<string, IList<FieldEntry>>() },
            };

            foreach (var url in urls)
            {
                var res = await http.GetAsync(url.Value);
                if (!res.IsSuccessStatusCode) // A couple of these don't exist yet
                    return;
                string data = await res.Content.ReadAsStringAsync();

                IList<string> lines = splitLines.Split(data);

                var structName = string.Empty;
                var curOffset = 0;
                var fields = new List<FieldEntry>();
                foreach (string iline in lines)
                {
                    string line = iline.Trim();

                    if (line.IndexOf("<") != -1)
                    {
                        structName = line.Substring(line.IndexOf("<") + 2, line.IndexOf(">") - 1);
                    }

                    if (line.StartsWith("/") || line == string.Empty)
                        continue;

                    string[] words = splitSpaces.Split(line);
                    var cppTypeName = words[0];
                    if (cppTypeName == "unsigned")
                    {
                        string fixedTypeName = string.Empty;
                        if (words[1] == "char")
                            fixedTypeName = "uint8_t";
                        else if (words[1] == "short")
                            fixedTypeName = "uint16_t";
                        else if (words[1] == "int")
                            fixedTypeName = "uint32_t";
                        words = words[2..].Prepend(fixedTypeName).ToArray();
                        cppTypeName = fixedTypeName;
                    }

                    bool isArray = false;
                    int arraySize = -1;
                    if (cppTypeName.IndexOf("[") != -1)
                    {
                        isArray = true;
                        string arraySizeStr = cppTypeName.Substring(cppTypeName.IndexOf("[") + 1, cppTypeName.IndexOf("]"));
                        if (!int.TryParse(arraySizeStr, out int readSize))
                        {
                            arraySize = (int)Convert.ToUInt32(arraySizeStr);
                        }
                        else
                        {
                            arraySize = readSize;
                        }
                        cppTypeName = cppTypeName.Substring(0, cppTypeName.IndexOf("["));
                    }

                    int cppTypeSize = 0;
                    bool isSigned = false;
                    if (cppTypeName == "uint8_t" || cppTypeName == "char")
                        cppTypeSize = 1;
                    else if (cppTypeName == "uint16_t")
                        cppTypeSize = 2;
                    else if (cppTypeName == "uint32_t")
                        cppTypeSize = 4;
                    else if (cppTypeName == "uint64_t")
                        cppTypeSize = 8;
                    else if (cppTypeName == "int8_t")
                    {
                        cppTypeSize = 1;
                        isSigned = true;
                    }
                    else if (cppTypeName == "int16_t")
                    {
                        cppTypeSize = 2;
                        isSigned = true;
                    }
                    else if (cppTypeName == "int32_t" || cppTypeName == "float")
                    {
                        cppTypeSize = 4;
                        isSigned = true;
                    }
                    else if (cppTypeName == "int64_t" || cppTypeName == "double")
                    {
                        cppTypeSize = 8;
                        isSigned = true;
                    }

                    var fieldEntry = new FieldEntry
                    {
                        Name = words[1],
                        Offset = curOffset,
                        CppTypeName = cppTypeName,
                        UnitSize = cppTypeSize,
                        IsSigned = isSigned,
                        IsArray = isArray,
                        ArraySize = arraySize,
                    };
                    curOffset += cppTypeSize;
                    fields.Add(fieldEntry);

                    if (line.IndexOf("}") != -1)
                    {
                        output[url.Key].Add(structName, fields);

                        structName = string.Empty;
                        fields = new List<FieldEntry>();
                    }
                }
            }

            var path1 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "structures.json");
            File.WriteAllText(path1, JsonConvert.SerializeObject(output, Formatting.Indented));

            var path2 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "structures.min.json");
            File.WriteAllText(path2, JsonConvert.SerializeObject(output));

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
