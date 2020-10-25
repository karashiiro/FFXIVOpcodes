using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FFXIVDataStructures
{
    public static class Program
    {
        public static async Task Main(string[] _)
        {
            Console.WriteLine("Exporting...");

            var http = new HttpClient();
            var urls = new Dictionary<string, string>
            {
                { "ServerZoneDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Zone/ServerZoneDef.h" },
                { "ClientZoneDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Zone/ClientZoneDef.h" },
                { "ServerLobbyDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Lobby/ServerLobbyDef.h" },
                { "ClientLobbyDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Lobby/ClientLobbyDef.h" },
                { "ServerChatDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Chat/ServerChatDef.h" },
                { "ClientChatDef", "https://raw.githubusercontent.com/SapphireServer/Sapphire/develop/src/common/Network/PacketDef/Chat/ClientChatDef.h" },
            };
            var splitLines = new Regex(@"\r\n", RegexOptions.Compiled);
            var splitSpaces = new Regex(@" ", RegexOptions.Compiled);
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
                var data = await res.Content.ReadAsStringAsync();

                IList<string> lines = splitLines.Split(data);

                var structName = string.Empty;
                var curOffset = 0;
                var fields = new List<FieldEntry>();
                foreach (var iline in lines)
                {
                    var line = iline.Trim();

                    if (line.IndexOf("<") != -1)
                    {
                        structName = line.Substring(line.IndexOf("<") + 2, line.IndexOf(">") - 1);
                    }

                    if (line.StartsWith("/") || line == string.Empty)
                        continue;

                    var words = splitSpaces.Split(line);
                    var cppTypeName = words[0];
                    if (cppTypeName == "unsigned")
                    {
                        var fixedTypeName = words[1] switch
                        {
                            "char" => "uint8_t",
                            "short" => "uint16_t",
                            "int" => "uint32_t",
                            _ => string.Empty
                        };
                        words = words[2..].Prepend(fixedTypeName).ToArray();
                        cppTypeName = fixedTypeName;
                    }

                    var isArray = false;
                    var arraySize = -1;
                    if (cppTypeName.IndexOf("[") != -1)
                    {
                        isArray = true;
                        var arraySizeStr = cppTypeName.Substring(cppTypeName.IndexOf("[") + 1, cppTypeName.IndexOf("]"));
                        if (!int.TryParse(arraySizeStr, out var readSize))
                        {
                            arraySize = (int)Convert.ToUInt32(arraySizeStr);
                        }
                        else
                        {
                            arraySize = readSize;
                        }
                        cppTypeName = cppTypeName.Substring(0, cppTypeName.IndexOf("["));
                    }

                    var cppTypeSize = 0;
                    var isSigned = false;
                    switch (cppTypeName)
                    {
                        case "uint8_t":
                        case "char":
                            cppTypeSize = 1;
                            break;
                        case "uint16_t":
                            cppTypeSize = 2;
                            break;
                        case "uint32_t":
                            cppTypeSize = 4;
                            break;
                        case "uint64_t":
                            cppTypeSize = 8;
                            break;
                        case "int8_t":
                            cppTypeSize = 1;
                            isSigned = true;
                            break;
                        case "int16_t":
                            cppTypeSize = 2;
                            isSigned = true;
                            break;
                        case "int32_t":
                        case "float":
                            cppTypeSize = 4;
                            isSigned = true;
                            break;
                        case "int64_t":
                        case "double":
                            cppTypeSize = 8;
                            isSigned = true;
                            break;
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

                    if (line.IndexOf("}") == -1) continue;
                    output[url.Key].Add(structName, fields);

                    structName = string.Empty;
                    fields = new List<FieldEntry>();
                }
            }

            var path1 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "structures.json");
            await File.WriteAllTextAsync(path1, JsonConvert.SerializeObject(output, Formatting.Indented));

            var path2 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "structures.min.json");
            await File.WriteAllTextAsync(path2, JsonConvert.SerializeObject(output));

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
