namespace Melody.BusinessLayer.Requests.Follows
{
    public class FollowTrackRequest : FollowRequest
    {
        public Guid TrackId { get; set; }
    }
}
