namespace Melody.BusinessLayer.Requests.Tracks
{
    public class IncludeTrackIntoPlaylistRequest
    {
        public object TrackId { get; set; }

        public string[] PlaylistIds { get; set; }
    }
}
