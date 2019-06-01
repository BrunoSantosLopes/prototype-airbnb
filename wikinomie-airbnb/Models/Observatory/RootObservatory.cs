using Newtonsoft.Json;

namespace PrototypeWikinomie.Models.Observatory
{
    public class RootObservatory
    {
        [JsonProperty(PropertyName = "dictionary")]
        public ObservatoyContainer Dictionary { get; set; }
    }
}
