using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_POST.Jsons
{

    public class Others
    {
        public class Autorization
        {
            public class Response
            {

                [JsonProperty("authenticated")]
                public bool Authenticated { get; set; }
            }
        }

        public class Bad_Request
        {
            public class Json_Token
            {

                [JsonProperty("checkpoint_url")]
                public string Value { get; set; }

            }

            public class Response
            {

                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("text")]
                public string Text { get; set; }

                [JsonProperty("created_time")]
                public long CreatedTime { get; set; }

                [JsonProperty("status")]
                public string Status { get; set; }


            }
        }

        public class Subscibles_Reserve
        {
            public partial class Welcome
            {
                [JsonProperty("graphql")]
                public Graphql Graphql { get; set; }
            }

            public partial class Graphql
            {
                [JsonProperty("user")]
                public GraphqlUser User { get; set; }
            }

            public partial class GraphqlUser
            {
                [JsonProperty("activity_feed")]
                public ActivityFeed ActivityFeed { get; set; }
            }

            public partial class ActivityFeed
            {
                //[JsonProperty("timestamp")]
                //public double Timestamp { get; set; }

                [JsonProperty("edge_web_activity_feed")]
                public EdgeWebActivityFeed EdgeWebActivityFeed { get; set; }
            }

            public partial class EdgeWebActivityFeed
            {
                //[JsonProperty("count")]
                //public long Count { get; set; }

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
                //[JsonProperty("id")]
                //public string Id { get; set; }

                [JsonProperty("type")]
                public int Type { get; set; }

                //[JsonProperty("timestamp")]
                //public double Timestamp { get; set; }

                [JsonProperty("__typename")]
                public string Typename { get; set; }

                [JsonProperty("user")]
                public NodeUser User { get; set; }

            }

            public partial class NodeUser
            {
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("username")]
                public string Username { get; set; }

                [JsonProperty("full_name")]
                public string FullName { get; set; }

                [JsonProperty("profile_pic_url")]
                public Uri ProfilePicUrl { get; set; }

                [JsonProperty("reel")]
                public Reel Reel { get; set; }

                [JsonProperty("requested_by_viewer", NullValueHandling = NullValueHandling.Ignore)]
                public bool? RequestedByViewer { get; set; }

                [JsonProperty("followed_by_viewer", NullValueHandling = NullValueHandling.Ignore)]
                public bool? FollowedByViewer { get; set; }
            }

            public partial class Reel
            {
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("expiring_at")]
                public int ExpiringAt { get; set; }

                //[JsonProperty("has_pride_media")]
                //public bool HasPrideMedia { get; set; }
            }
        }
    }
}
