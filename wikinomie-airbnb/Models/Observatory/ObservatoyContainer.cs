using Newtonsoft.Json;
using System.Collections.Generic;

namespace WikinomieAirbnb.Models.Observatory
{
    public class ObservatoyContainer
    {
        public string Id { get; set; }
        public Dictionary<string, Entry> Entries { get; set; }

        [JsonProperty(PropertyName = "member_list ")]
        public List<string> Members { get; set; }
        public string Date { get; set; }
        public string Previous { get; set; }
        public string Author { get; set; }
    }
}