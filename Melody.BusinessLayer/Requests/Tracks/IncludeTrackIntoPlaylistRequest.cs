namespace Melody.BusinessLayer.Requests.Tracks
{
    public class IncludeTrackIntoPlaylistRequest
    {
        public Guid TrackId { get; set; }

        public Guid? PlaylistId { get; set; }
    }
}
