using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Jestor_SDK.Types
{
    public class JestorResponse
    {
        [JsonPropertyName("status")]
        public bool status { get; set; }

        

        [JsonPropertyName("metadata")]
        public Metadata metadata { get; set; }

        public class Metadata
        {
            [JsonPropertyName("response")]
            public string response { get; set; }

            [JsonPropertyName("message")]
            public string message { get; set; }

            [JsonPropertyName("org")]
            public string org { get; set; }

            [JsonPropertyName("notifications")]
            public List<object> notifications { get; set; }
        }
    }
}
