using Newtonsoft.Json;
using System.Collections.Generic;

namespace FFXIVOpcodes
{
    class RegionSet
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("lists")]
        public Dictionary<string, List<OutputEntry>> Lists { get; set; }

        public RegionSet()
        {
            Lists = new Dictionary<string, List<OutputEntry>>
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
