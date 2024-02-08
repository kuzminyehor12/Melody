namespace Melody.Services.Interfaces
{
    public interface IAudioLibraryApiClient
    {
        public Task<object> GetAuthorsAsync(CancellationToken cancellationToken = default);

        public Task<object> GetAudioBooksAsync(CancellationToken cancellationToken = default);

        public Task<object> GetAudioBookCollectionsAsync(CancellationToken cancellationToken = default);
    }
}
