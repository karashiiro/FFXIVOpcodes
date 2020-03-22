using Newtonsoft.Json;

namespace FFXIVOpcodes
{
    struct OutputEntry
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("opcode")]
        public int Opcode;

        [JsonProperty("version")]
        public string Version;
    }
}
