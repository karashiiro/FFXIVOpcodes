using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace FFXIVOpcodes
{
    class Program
    {
        static void Main(string[] _)
        {
            Console.WriteLine("Exporting...");

            List<RegionSet> regions = new List<RegionSet>{
                new RegionSet { Region = "Global" },
                new RegionSet { Region = "CN" },
                new RegionSet { Region = "KR" },
            };

            Type[][] enums = {
                new Type[] { typeof(Global.ServerZoneIpcType), typeof(Global.ClientZoneIpcType), typeof(Global.ServerChatIpcType), typeof(Global.ClientChatIpcType), typeof(Global.ServerLobbyIpcType), typeof(Global.ClientLobbyIpcType), },
                new Type[] { typeof(CN.ServerZoneIpcType), typeof(CN.ClientZoneIpcType), typeof(CN.ServerChatIpcType), typeof(CN.ClientChatIpcType), typeof(CN.ServerLobbyIpcType), typeof(CN.ClientLobbyIpcType), },
                new Type[] { typeof(KR.ServerZoneIpcType), typeof(KR.ClientZoneIpcType), typeof(KR.ServerChatIpcType), typeof(KR.ClientChatIpcType), typeof(KR.ServerLobbyIpcType), typeof(KR.ClientLobbyIpcType), },
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    foreach (var ipcCommand in Enum.GetValues(enums[i][j]))
                    {
                        var command = new OutputEntry
                        {
                            Name = ipcCommand.ToString(),
                            Opcode = (ipcCommand as IConvertible).ToInt32(CultureInfo.CurrentCulture),
                        };
                        regions[i].Lists[enums[i][j].Name].Add(command);
                    }
                    regions[i].Lists[enums[i][j].Name].Sort((obj1, obj2) => obj1.Name[0] - obj2.Name[0]);
                }
            }

            var path1 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "opcodes.json");
            File.WriteAllText(path1, JsonConvert.SerializeObject(regions, Formatting.Indented));

            var path2 = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "..", "opcodes.min.json");
            File.WriteAllText(path2, JsonConvert.SerializeObject(regions));

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
