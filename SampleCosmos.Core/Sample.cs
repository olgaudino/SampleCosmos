using Newtonsoft.Json;

namespace SampleCosmos.Core
{
    public class Sample
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        public string Content { get; set; }
    }
}
