using Microsoft.AspNetCore.Http;

namespace Melody.BusinessLayer.Utils
{
    public class PersistentFile
    {
        private readonly IFormFile? _formFile;

        public Guid PersistanceKey { get; set; }

        public PersistentFile(IFormFile? formFile)
        {
            _formFile = formFile;
            PersistanceKey = Guid.NewGuid();
        }

        public string ContentType => _formFile?.ContentType ?? string.Empty;

        public string FileName
        {
            get => _formFile is null ? string.Empty : string.Join("-", PersistanceKey, _formFile?.FileName);
        }

        public Stream Read()
        {
            return _formFile?.OpenReadStream() ?? Stream.Null;
        }
    }
}
