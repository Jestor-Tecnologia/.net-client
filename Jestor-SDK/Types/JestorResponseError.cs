using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Jestor_SDK.Types
{
    public class JestorResponseError : JestorResponse
    {
        
        [JsonPropertyName("data")]
        public Data data { get; set; }

        

        public class Data
        {
            [JsonPropertyName("message")]
            public string message { get; set; }

            [JsonPropertyName("url")]
            public string url { get; set; }

            [JsonPropertyName("code")]
            public int code { get; set; }
        }
       
    }
}

