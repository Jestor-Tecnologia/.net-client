using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Jestor_SDK.Types
{
    
    public class ArgumentFetch
    {
        public string table_name { get; set; }
        public string filters { get; set; }
        public int limit { get; set; }
        public int page { get; set; }
        public string sort { get; set; }
        public List<string> fields_to_select { get; set; }
        public string fetch_type { get; set; } = "single";

    }
}
