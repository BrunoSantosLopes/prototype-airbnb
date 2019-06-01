using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Linq;
using WikinomieAirbnb.Models;
using WikinomieAirbnb.Models.Observatory;
using WikinomieAirbnb.Models.Tags;

namespace WikinomieAirbnb
{
    public class CowabooService
    {
        private const string urlCowaboo = "http://groups.cowaboo.net/2019/group07%20-%20Airbnb%20en%202019/public/api/";

        public List<string> GetTags()
        {
            RestClient client = new RestClient(urlCowaboo);
            RestRequest request = new RestRequest("tags", Method.GET);

            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                return new List<string>();

            RootTags root = JsonConvert.DeserializeObject<RootTags>(response.Content);

            return root.TagList.List.Keys.ToList();
        }

        public List<Entry> GetTagsValues(string observatory)
        {
            RestClient client = new RestClient(urlCowaboo);
            RestRequest request = new RestRequest("observatory", Method.GET);
            request.AddParameter("observatoryId", observatory);
            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful || string.IsNullOrEmpty(response.Content))
                return new List<Entry>();

            RootObservatory root = JsonConvert.DeserializeObject<RootObservatory>(response.Content);
            return root.Dictionary.Entries.Values.ToList();

        }

        internal bool SendEntry(SendEntry entry)
        {
            RestClient client = new RestClient(urlCowaboo);
            RestRequest request = new RestRequest("entry", Method.POST);
            request.AddParameter("secretKey", entry.SecretKey);
            request.AddParameter("observatoryId", entry.ObservatoryId);
            request.AddParameter("tags", entry.Tags);
            request.AddParameter("value", entry.Value);

            IRestResponse response = client.Execute(request);

            if (!response.IsSuccessful)
                return false;

            return true;

        }
    }
}
