using Newtonsoft.Json;

namespace FFXIVDataStructures
{
    public struct FieldEntry
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("offset")]
        public int Offset;

        // Even with the following two fields, there's no way to distinguish between a uint8 and a char among others, so we keep this, too.
        [JsonProperty("cppTypeName")]
        public string CppTypeName;

        [JsonProperty("typeSize")]
        public int UnitSize;

        [JsonProperty("isSigned")]
        public bool IsSigned;

        [JsonProperty("isArray")]
        public bool IsArray;

        [JsonProperty("arraySize")]
        public int ArraySize;
    }
}
