using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_POST.Jsons
{
    class Search_Json
    {
        [JsonProperty("users")]
        public UserElement[] Users { get; set; }

        [JsonProperty("hashtags")]
        public HashtagElement[] Hashtags { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("rank_token")]
        public string RankToken { get; set; }


        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class HashtagElement
    {
        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("hashtag")]
        public HashtagHashtag Hashtag { get; set; }
    }

    public partial class HashtagHashtag
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("media_count")]
        public long MediaCount { get; set; }

        [JsonProperty("use_default_avatar")]
        public bool UseDefaultAvatar { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("search_result_subtitle")]
        public string SearchResultSubtitle { get; set; }
    }

    public partial class UserElement
    {
        [JsonProperty("user")]
        public UserUser User { get; set; }
    }

    public partial class UserUser
    {
        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("friendship_status")]
        public Friendship_Status Friendship_Status { get; set; }
    }

    public partial class Friendship_Status
    {
        [JsonProperty("following")]
        public bool Following { get; set; }
    }
}
