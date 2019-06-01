using Newtonsoft.Json;

namespace PrototypeWikinomie.Models.Tags
{
    public class RootTags
    {
        [JsonProperty(PropertyName = "tag_list")]
        public TagList TagList { get; set; }
    }
}
