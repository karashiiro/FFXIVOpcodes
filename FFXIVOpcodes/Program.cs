using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;

namespace FFXIVOpcodes
{
    public static class Program
    {
        public static void Main()
        {
            ValidateOpcodes();

            Console.WriteLine("Exporting...");

            var regions = new List<RegionSet>{
                new RegionSet { Region = "Global", Version = "6.05"},
                new RegionSet { Region = "CN", Version = FFXIVConstants.CN.Version }, // <3
                new RegionSet { Region = "KR", Version = "6.01" },
            };

            Type[][] enums = {
                new[] { typeof(Global.ServerZoneIpcType), typeof(Global.ClientZoneIpcType), typeof(Global.ServerChatIpcType), typeof(Global.ClientChatIpcType), typeof(Global.ServerLobbyIpcType), typeof(Global.ClientLobbyIpcType), },
                new[] { typeof(CN.ServerZoneIpcType), typeof(CN.ClientZoneIpcType), typeof(CN.ServerChatIpcType), typeof(CN.ClientChatIpcType), typeof(CN.ServerLobbyIpcType), typeof(CN.ClientLobbyIpcType), },
                new[] { typeof(KR.ServerZoneIpcType), typeof(KR.ClientZoneIpcType), typeof(KR.ServerChatIpcType), typeof(KR.ClientChatIpcType), typeof(KR.ServerLobbyIpcType), typeof(KR.ClientLobbyIpcType), },
            };

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 6; j++)
                {
                    foreach (var ipcCommand in Enum.GetValues(enums[i][j]))
                    {
                        var command = new OpcodeEntry
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
        }

        private static void ValidateOpcodes()
        {
            var globalIpcLists = new[] { typeof(Global.ClientChatIpcType), typeof(Global.ServerChatIpcType), typeof(Global.ClientLobbyIpcType), typeof(Global.ServerLobbyIpcType), typeof(Global.ClientZoneIpcType), typeof(Global.ServerZoneIpcType) };
            var cnIpcLists = new[] { typeof(CN.ClientChatIpcType), typeof(CN.ServerChatIpcType), typeof(CN.ClientZoneIpcType), typeof(CN.ServerZoneIpcType) };
            var krIpcLists = new[] { typeof(KR.ClientChatIpcType), typeof(KR.ServerChatIpcType), typeof(KR.ClientLobbyIpcType), typeof(KR.ServerLobbyIpcType), typeof(KR.ClientZoneIpcType), typeof(KR.ServerZoneIpcType) };
            var ipcListsList = new[] { globalIpcLists, cnIpcLists, krIpcLists };
            foreach (var ipcLists in ipcListsList)
            {
                foreach (var ipcList in ipcLists)
                {
                    var ipcValues = (ushort[])Enum.GetValues(ipcList);
                    if (ipcValues.Distinct().Count() != ipcValues.Length)
                    {
                        Console.WriteLine("##### DUPLICATES");
                        var duplicates = ipcValues
                                           .GroupBy(p => p)
                                           .Where(g => g.Count() > 1)
                                           .Select(g => $"0x{g.Key:X}");
                        foreach(var dupe in duplicates)
                        {
                            Console.WriteLine(dupe);
                        }
                        throw new ConstraintException($"{ipcList.Name} contains one or more duplicate values!");
                    }
                }
            }
        }
    }
}
