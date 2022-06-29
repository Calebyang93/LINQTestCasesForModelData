using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebAPIClient
{
    public class repo
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("html_url")]
        public Uri gitHubHomeUrl { get; set; }

        [JsonPropertyName("homepage")]
        public Uri homePage { get; set; }

        [JsonPropertyName("watchers")]
        public int Watchers { get; set; }

        [JsonPropertyName("pushed_at")]
        public DateTime LastPushedUtc { get; set; }
        public DateTime LastPush => LastPushedUtc.ToLocalTime();
    }
}
