using System;
using System.Collections.Generic;
using System.Text;

namespace Jestor_SDK.Types
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Item
    {
        public string id { get; set; }
        public string type { get; set; }
        public List<object> items { get; set; }
        public string label { get; set; }
    }

    public class Users
    {
        public int id_user { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public object is_portal { get; set; }
        public string photo_url { get; set; }
        public object display_name { get; set; }
        public List<Tab> tabs { get; set; }
    }

    public class Tab
    {
        public string id { get; set; }
        public string type { get; set; }
        public List<Item> items { get; set; }
        public string label { get; set; }
    }


}
