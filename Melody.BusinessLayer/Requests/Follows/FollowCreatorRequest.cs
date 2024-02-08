namespace Melody.BusinessLayer.Requests.Follows
{
    public class FollowCreatorRequest : FollowRequest
    {
        public Guid CreatorId { get; set; }
    }
}
