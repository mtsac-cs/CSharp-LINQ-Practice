using Newtonsoft.Json;

namespace LINQ_Practice.Lib
{
    public partial class ExtraPiece
    {
        [JsonProperty("r")]
        public long R { get; set; }

        [JsonProperty("g")]
        public long G { get; set; }

        [JsonProperty("b")]
        public long B { get; set; }

        [JsonProperty("a")]
        public long A { get; set; }
    }
}
