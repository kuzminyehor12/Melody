using Melody.Shared;

namespace Melody.Services.Interfaces
{
    public interface IFileStorageService
    {
        public Task<Result> PutAsync(string fileName, Stream stream, CancellationToken cancellationToken);

        public Task<string> DownloadAsync(string fileName);
    }
}
