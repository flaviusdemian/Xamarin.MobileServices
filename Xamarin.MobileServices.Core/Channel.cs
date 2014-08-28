using System;
using Newtonsoft.Json;

namespace Xamarin.MobileServices.Core
{
    public class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("deviceType")]
        public Enums.DeviceType DeviceType { get; set; }

        [JsonProperty("channelUri")]
        public String ChannelUri { get; set; }

        [JsonProperty("registrationId")]
        public String RegistrationId { get; set; }

        [JsonProperty("userId")]
        public String UserId { get; set; }
    }
}