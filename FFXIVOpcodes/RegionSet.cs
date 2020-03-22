using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FFXIVOpcodes
{
    class RegionSet
    {
        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("lists")]
        public Dictionary<string, List<OutputEntry>> Lists { get; set; }

        [JsonIgnore]
        public string Version { get; set; }

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
