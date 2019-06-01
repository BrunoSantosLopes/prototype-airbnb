using Newtonsoft.Json;

namespace WikinomieAirbnb.Models.Observatory
{
    public class RootObservatory
    {
        [JsonProperty(PropertyName = "dictionary")]
        public ObservatoyContainer Dictionary { get; set; }
    }
}
