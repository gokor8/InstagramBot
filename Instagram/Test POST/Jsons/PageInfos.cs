using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_POST.Jsons
{
    class PageInfos
    {
        public partial class Info_Page
        {
            public partial class Config
            {

                [JsonProperty("country_code")]
                public string CountryCode { get; set; }

                [JsonProperty("language_code")]
                public string LanguageCode { get; set; }

                [JsonProperty("entry_data")]
                public EntryData EntryData { get; set; }

                [JsonProperty("hostname")]
                public string Hostname { get; set; }

                [JsonProperty("is_whitelisted_crawl_bot")]
                public bool IsWhitelistedCrawlBot { get; set; }

                [JsonProperty("connection_quality_rating")]
                public string ConnectionQualityRating { get; set; }

                [JsonProperty("deployment_stage")]
                public string DeploymentStage { get; set; }

                [JsonProperty("platform")]
                public string Platform { get; set; }

                [JsonProperty("nonce")]
                public string Nonce { get; set; }

                [JsonProperty("mid_pct")]
                public double MidPct { get; set; }

                [JsonProperty("frontend_env")]
                public string FrontendEnv { get; set; }
            }

            public partial class EntryData
            {
                [JsonProperty("ProfilePage")]
                public ProfilePage[] ProfilePage { get; set; }
            }

            public partial class ProfilePage
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
                [JsonProperty("username")]
                public string Username { get; set; }

                [JsonProperty("biography")]
                public string Biography { get; set; }

                [JsonProperty("blocked_by_viewer")]
                public bool BlockedByViewer { get; set; }

                [JsonProperty("restricted_by_viewer")]
                public bool RestrictedByViewer { get; set; }

                [JsonProperty("country_block")]
                public bool CountryBlock { get; set; }

                [JsonProperty("fbid")]
                public string Fbid { get; set; }

                [JsonProperty("followed_by_viewer")]
                public bool FollowedByViewer { get; set; }


                [JsonProperty("follows_viewer")]
                public bool FollowsViewer { get; set; }

                [JsonProperty("full_name")]
                public string FullName { get; set; }

                [JsonProperty("has_ar_effects")]
                public bool HasArEffects { get; set; }

                [JsonProperty("has_clips")]
                public bool HasClips { get; set; }

                [JsonProperty("has_guides")]
                public bool HasGuides { get; set; }

                [JsonProperty("has_channel")]
                public bool HasChannel { get; set; }

                [JsonProperty("has_blocked_viewer")]
                public bool HasBlockedViewer { get; set; }

                [JsonProperty("highlight_reel_count")]
                public long HighlightReelCount { get; set; }

                [JsonProperty("has_requested_viewer")]
                public bool HasRequestedViewer { get; set; }

                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("is_business_account")]
                public bool IsBusinessAccount { get; set; }

                [JsonProperty("is_joined_recently")]
                public bool IsJoinedRecently { get; set; }

                [JsonProperty("category_name")]
                public string CategoryName { get; set; }

                [JsonProperty("is_private")]
                public bool IsPrivate { get; set; }

                [JsonProperty("is_verified")]
                public bool IsVerified { get; set; }


                [JsonProperty("profile_pic_url")]
                public Uri ProfilePicUrl { get; set; }

                [JsonProperty("profile_pic_url_hd")]
                public Uri ProfilePicUrlHd { get; set; }

                [JsonProperty("requested_by_viewer")]
                public bool RequestedByViewer { get; set; }

                [JsonProperty("should_show_category")]
                public bool ShouldShowCategory { get; set; }

                [JsonProperty("connected_fb_page")]
                public object ConnectedFbPage { get; set; }


                [JsonProperty("edge_owner_to_timeline_media")]
                public EdgeFelixVideoTimelineClass EdgeOwnerToTimelineMedia { get; set; }

            }

            public partial class EdgeFelixVideoTimelineClass
            {
                [JsonProperty("edges")]
                public Edges[] Edges { get; set; }
            }

            public partial class NodeUser
            {

                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonProperty("is_verified")]
                public bool IsVerified { get; set; }

                [JsonProperty("profile_pic_url")]
                public Uri ProfilePicUrl { get; set; }

            }

            public partial class Edges
            {
                [JsonProperty("node")]
                public Node Node { get; set; }
            }

            public partial class Node
            {
                [JsonProperty("id")]
                public string id { get; set; }

                [JsonProperty("shortcode")]
                public string Shortcode { get; set; }
            }
        }

        public class Image_Info
        {
            public partial class Config
            {
                [JsonProperty("entry_data")]
                public EntryData EntryData { get; set; }
            }

            public partial class EntryData
            {
                [JsonProperty("PostPage")]
                public PostPage[] PostPage { get; set; }
            }

            public partial class PostPage
            {
                [JsonProperty("graphql")]
                public Graphql Graphql { get; set; }
            }

            public partial class Graphql
            {
                [JsonProperty("shortcode_media")]
                public ShortcodeMedia ShortcodeMedia { get; set; }
            }

            public partial class ShortcodeMedia
            {

                [JsonProperty("viewer_has_liked")]
                public bool ViewerHasLiked { get; set; }

            }


        }

        public class Image_Info_Urez
        {
            public partial class Config
            {
                [JsonProperty("entry_data")]
                public EntryData EntryData { get; set; }
            }

            public partial class EntryData
            {
                [JsonProperty("PostPage")]
                public PostPage[] PostPage { get; set; }
            }

            public partial class PostPage
            {
                [JsonProperty("graphql")]
                public Graphql Graphql { get; set; }
            }

            public partial class Graphql
            {
                [JsonProperty("shortcode_media")]
                public ShortcodeMedia ShortcodeMedia { get; set; }
            }

            public partial class ShortcodeMedia
            {

                [JsonProperty("viewer_has_liked")]
                public bool ViewerHasLiked { get; set; }

            }
        }
    }
}
