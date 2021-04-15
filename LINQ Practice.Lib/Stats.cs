using Newtonsoft.Json;

namespace LINQ_Practice.Lib
{
    public partial class Stats
    {
        [JsonProperty("health")]
        public long Health { get; set; }

        [JsonProperty("strength")]
        public long Strength { get; set; }

        [JsonProperty("armor")]
        public long Armor { get; set; }

        [JsonProperty("speed")]
        public long Speed { get; set; }

        [JsonProperty("intelligence")]
        public long Intelligence { get; set; }
    }
}
