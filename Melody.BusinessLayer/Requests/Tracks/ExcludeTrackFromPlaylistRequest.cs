namespace Melody.BusinessLayer.Requests.Tracks
{
    public class ExcludeTrackFromPlaylistRequest
    {
        public Guid TrackId { get; set; }

        public Guid PlaylistId { get; set; }
    }
}
