using Melody.Services.Interfaces;
using Melody.Services.WebServices;
using Melody.Shared;
using Microsoft.AspNetCore.Http;

namespace Melody.BusinessLayer.Tasks
{
    public static class TaskProvider
    {
        public static Func<Task<Result>> CreateUploadTask(
            IFormFile? file,
            string bucketName,
            Func<Result> onNull, 
            IFileStorageService fileStorageService, 
            CancellationToken cancellationToken = default)
        {
            return async () =>
            {
                if (file is not null)
                {
                    using (var stream = file.OpenReadStream())
                    {
                        var innerResult = await fileStorageService.PutAsync(bucketName, file.FileName, stream, cancellationToken);
                        return innerResult;
                    }
                }

                return onNull();
            };
        }
    }
}
