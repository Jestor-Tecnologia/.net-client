using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Jestor_SDK.Filters
{
    public class Filter
    {
        [JsonPropertyName("field")]
        public string Field { get; private set; }
        [JsonPropertyName("value")]
        public string Value { get; private set; }
        [JsonPropertyName("type")]
        public string Type { get; private set; }
        [JsonPropertyName("operator")]
        public string Operator { get; private set; }

        //public List<string> data { get; private set; }

        public Filter(string field, string value, string type, Operators _operator)
        {
            this.Field = field;
            this.Value = value;
            this.Type = type;
            this.Operator = _operator.ToString().ToLower();
            //var filter = new List<string> { field, value, _operator.ToString().ToLower(), type };
            //data = filter;

        }
    }
}
