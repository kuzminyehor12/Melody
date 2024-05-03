using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.AudioBooks;
using Melody.BusinessLayer.Utils;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Services.Interfaces;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class AudioBookService : WriteService, IAudioBookService
    {
        private readonly IFileStorageService _fileStorageService;
        public AudioBookService(RepositoryContext context, IMapper mapper, IFileStorageService fileStorageService) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
        }

        public async Task<Result> AddAsync(CreateAudioBookRequest request, CancellationToken cancellationToken)
        {
            var audioBook = _mapper.Map<AudioBook>(request);
            var result = await _context.AudioBooks.CreateAsync(audioBook, cancellationToken);
            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<IEnumerable<AudioBookDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken)
        {
            var audioBooks = await _context.AudioBooks.ArrayAsync(
               a => a.Title.ToLower().Contains(searchString.ToLower()) 
               || a.Author.ToLower().Contains(searchString.ToLower()) 
               || a.Description.ToLower().Contains(searchString.ToLower()) 
               || a.AudioBookCollection.Title.ToLower().Contains(searchString.ToLower()),
               t => t.ListeningsCount,
               AllIncludeProperties(),
               true,
               cancellationToken);

            var dtos = audioBooks.Select(_mapper.Map<AudioBookDto>).ToList();

            foreach (var dto in dtos)
            {
                if (!string.IsNullOrEmpty(dto.Coversheet))
                {
                    dto.CoversheetUrl = await _fileStorageService.DownloadAsync(BucketName.Coversheets, dto.Coversheet);
                }

                dto.DownloadUrl = await _fileStorageService.DownloadAsync(BucketName.Audios, dto.Filename);
            }

            return dtos;
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return new List<string>
            {
                $"{nameof(AudioBook.Creator)}",
                $"{nameof(AudioBook.AudioBookCollection)}",
                $"{nameof(AudioBook.Followers)}"
            };
        }
    }
}
