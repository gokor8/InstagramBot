using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_POST.Jsons
{
    class Subcribles
    {
        public partial class Json
        {
            [JsonProperty("data")]
            public Data Data { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }
        }

        public partial class Data
        {
            [JsonProperty("user")]
            public User User { get; set; }
        }

        public partial class User
        {
            [JsonProperty("edge_followed_by")]
            public EdgeFollowedBy EdgeFollowedBy { get; set; }
        }

        public partial class EdgeFollowedBy
        {
            [JsonProperty("count")]
            public int Count_Subscribes { get; set; }

            [JsonProperty("page_info")]
            public PageInfo Pageinfo { get; set; }

            [JsonProperty("edges")]
            public Edge[] Edges { get; set; }
        }

        public partial class Edge
        {
            [JsonProperty("node")]
            public Node Node { get; set; }
        }

        public partial class Node
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("full_name")]
            public string FullName { get; set; }

            [JsonProperty("profile_pic_url")]
            public Uri ProfilePicUrl { get; set; }

            [JsonProperty("is_private")]
            public bool IsPrivate { get; set; }

            [JsonProperty("is_verified")]
            public bool IsVerified { get; set; }

            [JsonProperty("followed_by_viewer")]
            public bool FollowedByViewer { get; set; }

            [JsonProperty("requested_by_viewer")]
            public bool RequestedByViewer { get; set; }

            [JsonProperty("reel")]
            public Reel Reel { get; set; }
        }

        public partial class Reel
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("expiring_at")]
            public long ExpiringAt { get; set; }

            [JsonProperty("has_pride_media")]
            public bool HasPrideMedia { get; set; }

            [JsonProperty("latest_reel_media")]
            public long? LatestReelMedia { get; set; }

            [JsonProperty("seen")]
            public object Seen { get; set; }

            [JsonProperty("owner")]
            public Owner Owner { get; set; }
        }
        public partial class PageInfo
        {
            [JsonProperty("end_cursor")]
            public string End_Cursor { get; set; }
        }
    }
}
