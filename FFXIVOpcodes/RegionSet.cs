using Newtonsoft.Json;
using System.Collections.Generic;

namespace FFXIVOpcodes
{
    class RegionSet
    {
        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("lists")]
        public Dictionary<string, List<OpcodeEntry>> Lists { get; set; }

        public RegionSet()
        {
            Lists = new Dictionary<string, List<OpcodeEntry>>
            {
                { "ServerZoneIpcType", new List<OpcodeEntry>() },
                { "ClientZoneIpcType", new List<OpcodeEntry>() },
                { "ServerLobbyIpcType", new List<OpcodeEntry>() },
                { "ClientLobbyIpcType", new List<OpcodeEntry>() },
                { "ServerChatIpcType", new List<OpcodeEntry>() },
                { "ClientChatIpcType", new List<OpcodeEntry>() }
            };
        }
    }
}
