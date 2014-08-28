using Newtonsoft.Json;

namespace Xamarin.MobileServices.Core
{
    public class Friend
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}