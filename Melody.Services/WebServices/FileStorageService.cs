using Firebase.Storage;
using Melody.Services.Interfaces;
using Melody.Shared;

namespace Melody.Services.WebServices
{
    public class FileStorageService : IFileStorageService
    {
        private readonly FirebaseStorage _storage;

        public FileStorageService(FirebaseStorage storage)
        {
            _storage = storage;
        }

        public async Task<string> DownloadAsync(string fileName)
        {
            return await _storage
                .Child("audios")
                .Child(fileName)
                .GetDownloadUrlAsync();
        }

        public async Task<Result> PutAsync(string fileName, Stream stream, CancellationToken cancellationToken)
        {
            try
            {
                await _storage
                   .Child("audios")
                   .Child(fileName)
                   .PutAsync(stream, cancellationToken);

                return Result.Success();
            }
            catch (Exception ex)
            {
                return Result.Failure(ex);
            }
        }
    }
}
