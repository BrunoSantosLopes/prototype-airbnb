using Newtonsoft.Json;

namespace PrototypeWikinomie.Models
{
    [JsonObject(Title = "entry")]
    public class SendEntry
    {
        public string SecretKey { get; set; }
        public string ObservatoryId { get; set; }
        public string Tags { get; set; }
        public string Value { get; set; }

    }
}
