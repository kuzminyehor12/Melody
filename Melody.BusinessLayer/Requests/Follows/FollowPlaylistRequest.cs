namespace Melody.BusinessLayer.Requests.Follows
{
    public class FollowPlaylistRequest : FollowRequest
    {
        public Guid PlaylistId { get; set; }
    }
}
