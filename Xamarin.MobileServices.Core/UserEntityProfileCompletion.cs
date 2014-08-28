using Newtonsoft.Json;

namespace Xamarin.MobileServices.Core
{
    public class UserEntityProfileCompletion
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("accessTokenSecret")]
        public string AccessTokenSecret { get; set; }
    }
}