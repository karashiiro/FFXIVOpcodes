using Newtonsoft.Json;

namespace FFXIVOpcodes
{
    struct OpcodeEntry
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("opcode")]
        public int Opcode;
    }
}
