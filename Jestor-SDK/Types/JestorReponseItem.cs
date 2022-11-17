using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Jestor_SDK.Types
{
    public class JestorReponseItem : JestorResponse
    {
        [JsonPropertyName("data")]
        public dynamic data { get; set; }
    }
}
