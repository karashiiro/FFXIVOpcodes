using System.Collections.Generic;

namespace FFXIVOpcodes
{
    class RegionSet
    {
        public string region;
        public Dictionary<string, List<OutputEntry>> lists;

        public RegionSet()
        {
            lists = new Dictionary<string, List<OutputEntry>>
            {
                { "ServerZoneIpcType", new List<OutputEntry>() },
                { "ClientZoneIpcType", new List<OutputEntry>() },
                { "ServerLobbyIpcType", new List<OutputEntry>() },
                { "ClientLobbyIpcType", new List<OutputEntry>() },
                { "ServerChatIpcType", new List<OutputEntry>() },
                { "ClientChatIpcType", new List<OutputEntry>() }
            };
        }
    }
}
