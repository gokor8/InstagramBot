using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_POST.Jsons
{
    class Messages
    {
        [JsonProperty("inbox")]
        public Inbox Inboxx { get; set; }

        public partial class Inbox
        {
            [JsonProperty("threads")]
            public Threads[] Threadss { get; set; }
        }

        public partial class Threads
        {
            [JsonProperty("items")]
            public Items[] Itemss { get; set; }
        }

        public partial class Items
        {
            [JsonProperty("item_type")]
            public string Itemss { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }
        }
    }
}
