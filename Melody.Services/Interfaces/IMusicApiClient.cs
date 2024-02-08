namespace Melody.Services.Interfaces
{
    public interface IMusicApiClient
    {
        Task<object> GetTracksAsync(CancellationToken cancellationToken = default);

        Task<object> GetCreatorsAsync(CancellationToken cancellationToken = default);
    }
}
