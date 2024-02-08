namespace Melody.BusinessLayer.Requests.Follows
{
    public class FollowPodcastRequest : FollowRequest
    {
        public Guid PodcastId { get; set; }
    }
}
