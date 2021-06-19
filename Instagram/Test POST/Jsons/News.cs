using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_POST.Jsons
{
     class News
    {
        [JsonProperty("user")]
        public OwnerClass User { get; set; }
    }

    public partial class FluffyNode
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("did_report_as_spam")]
        public bool DidReportAsSpam { get; set; }

        [JsonProperty("owner")]
        public OwnerClass Owner { get; set; }

        [JsonProperty("viewer_has_liked")]
        public bool ViewerHasLiked { get; set; }
    }

    public partial class EdgeMediaPreviewCommentEdge
    {
        [JsonProperty("node")]
        public FluffyNode Node { get; set; }
    }

    public partial class EdgeMediaPreviewComment
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("edges")]
        public EdgeMediaPreviewCommentEdge[] Edges { get; set; }
    }

    public partial class PurpleNode
    {
        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("display_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri DisplayUrl { get; set; }

        [JsonProperty("display_resources", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayResource[] DisplayResources { get; set; }

        [JsonProperty("follow_hashtag_info")]
        public object FollowHashtagInfo { get; set; }

        [JsonProperty("is_video", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVideo { get; set; }

        [JsonProperty("tracking_token")]
        public string TrackingToken { get; set; }

        [JsonProperty("edge_media_to_tagged_user", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeMediaToTaggedUser EdgeMediaToTaggedUser { get; set; }

        [JsonProperty("attribution")]
        public object Attribution { get; set; }

        [JsonProperty("shortcode", NullValueHandling = NullValueHandling.Ignore)]
        public string Shortcode { get; set; }

        [JsonProperty("edge_media_to_caption", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeMediaTo EdgeMediaToCaption { get; set; }

        [JsonProperty("edge_media_preview_comment", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeMediaPreviewComment EdgeMediaPreviewComment { get; set; }

        [JsonProperty("gating_info")]
        public object GatingInfo { get; set; }

        [JsonProperty("fact_check_overall_rating")]
        public object FactCheckOverallRating { get; set; }

        [JsonProperty("fact_check_information")]
        public object FactCheckInformation { get; set; }

        [JsonProperty("media_overlay_info")]
        public object MediaOverlayInfo { get; set; }

        [JsonProperty("media_preview")]
        public string MediaPreview { get; set; }

        [JsonProperty("comments_disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CommentsDisabled { get; set; }

        [JsonProperty("taken_at_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public int? TakenAtTimestamp { get; set; }

        [JsonProperty("edge_media_preview_like", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeMediaPreviewLike EdgeMediaPreviewLike { get; set; }

        [JsonProperty("edge_media_to_sponsor_user", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeMediaTo EdgeMediaToSponsorUser { get; set; }

        [JsonProperty("viewer_has_liked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewerHasLiked { get; set; }

        [JsonProperty("viewer_has_saved", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewerHasSaved { get; set; }

        [JsonProperty("viewer_has_saved_to_collection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewerHasSavedToCollection { get; set; }

        [JsonProperty("viewer_in_photo_of_you", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewerInPhotoOfYou { get; set; }

        [JsonProperty("viewer_can_reshare", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ViewerCanReshare { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Owner Owner { get; set; }

        [JsonProperty("edge_sidecar_to_children", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeSidecarToChildren EdgeSidecarToChildren { get; set; }

        [JsonProperty("aysf", NullValueHandling = NullValueHandling.Ignore)]
        public Aysf[] Aysf { get; set; }

        public int? Type { get; set; }

        [JsonProperty("accessibility_caption", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessibilityCaption { get; set; }

        [JsonProperty("dash_info", NullValueHandling = NullValueHandling.Ignore)]
        public DashInfo DashInfo { get; set; }

        [JsonProperty("has_audio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasAudio { get; set; }

        [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri VideoUrl { get; set; }

        [JsonProperty("video_view_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoViewCount { get; set; }
    }

    public partial class EdgeWebFeedTimelineEdge
    {
        [JsonProperty("node")]
        public PurpleNode Node { get; set; }
    }

    public partial class EdgeWebFeedTimeline
    {
        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("edges")]
        public EdgeWebFeedTimelineEdge[] Edges { get; set; }
    }

    public partial class OwnerClass
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("edge_web_feed_timeline", NullValueHandling = NullValueHandling.Ignore)]
        public EdgeWebFeedTimeline EdgeWebFeedTimeline { get; set; }
    }

    public partial class PageInfo
    {
        [JsonProperty("has_next_page")]
        public bool HasNextPage { get; set; }

        [JsonProperty("end_cursor")]
        public string EndCursor { get; set; }
    }

    public partial class Aysf
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user")]
        public AysfUser User { get; set; }
    }

    public partial class AysfUser
    {
        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("edge_followed_by")]
        public EdgeFollowedBy EdgeFollowedBy { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("is_viewer")]
        public bool IsViewer { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class EdgeFollowedBy
    {
        [JsonProperty("count")]
        public int Count { get; set; }
    }

    public partial class DashInfo
    {
        [JsonProperty("is_dash_eligible")]
        public bool IsDashEligible { get; set; }

        [JsonProperty("video_dash_manifest")]
        public string VideoDashManifest { get; set; }

        [JsonProperty("number_of_qualities")]
        public int NumberOfQualities { get; set; }
    }

    public partial class Dimensions
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public partial class DisplayResource
    {
        [JsonProperty("src")]
        public Uri Src { get; set; }

        [JsonProperty("config_width")]
        public int ConfigWidth { get; set; }

        [JsonProperty("config_height")]
        public int ConfigHeight { get; set; }
    }

    public partial class EdgeMediaPreviewLike
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("edges")]
        public object[] Edges { get; set; }
    }

    public partial class EdgeMediaTo
    {
        [JsonProperty("edges")]
        public EdgeMediaToCaptionEdge[] Edges { get; set; }
    }

    public partial class EdgeMediaToCaptionEdge
    {
        [JsonProperty("node")]
        public TentacledNode Node { get; set; }
    }

    public partial class TentacledNode
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class EdgeMediaToTaggedUser
    {
        [JsonProperty("edges")]
        public PurpleEdge[] Edges { get; set; }
    }

    public partial class PurpleEdge
    {
        [JsonProperty("node")]
        public StickyNode Node { get; set; }
    }

    public partial class StickyNode
    {
        [JsonProperty("user")]
        public PurpleUser User { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public partial class PurpleUser
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class EdgeSidecarToChildren
    {
        [JsonProperty("edges")]
        public EdgeSidecarToChildrenEdge[] Edges { get; set; }
    }

    public partial class EdgeSidecarToChildrenEdge
    {
        [JsonProperty("node")]
        public IndigoNode Node { get; set; }
    }

    public partial class IndigoNode
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("display_url")]
        public Uri DisplayUrl { get; set; }

        [JsonProperty("display_resources")]
        public DisplayResource[] DisplayResources { get; set; }

        [JsonProperty("follow_hashtag_info")]
        public object FollowHashtagInfo { get; set; }

        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }

        [JsonProperty("tracking_token")]
        public string TrackingToken { get; set; }

        [JsonProperty("edge_media_to_tagged_user")]
        public EdgeMediaTo EdgeMediaToTaggedUser { get; set; }

        [JsonProperty("dash_info", NullValueHandling = NullValueHandling.Ignore)]
        public DashInfo DashInfo { get; set; }

        [JsonProperty("has_audio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasAudio { get; set; }

        [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri VideoUrl { get; set; }

        [JsonProperty("video_view_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoViewCount { get; set; }

        [JsonProperty("accessibility_caption", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessibilityCaption { get; set; }
    }
    public partial class Owner
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("followed_by_viewer")]
        public bool FollowedByViewer { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("requested_by_viewer")]
        public bool RequestedByViewer { get; set; }

        [JsonProperty("blocked_by_viewer")]
        public bool BlockedByViewer { get; set; }

        [JsonProperty("has_blocked_viewer")]
        public bool HasBlockedViewer { get; set; }

        [JsonProperty("restricted_by_viewer")]
        public bool RestrictedByViewer { get; set; }
    }
}
