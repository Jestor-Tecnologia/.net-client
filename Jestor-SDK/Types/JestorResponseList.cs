using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Jestor_SDK.Types
{
    public class JestorResponseList : JestorResponse
    {
        [JsonPropertyName("data")]
        public List<dynamic> data { get; set; }
    }
}
