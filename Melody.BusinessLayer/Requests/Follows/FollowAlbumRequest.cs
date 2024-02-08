namespace Melody.BusinessLayer.Requests.Follows
{
    public class FollowAlbumRequest : FollowRequest
    {
        public Guid AlbumId { get; set; }
    }
}
