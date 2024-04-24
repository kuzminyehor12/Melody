using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.AudioBooks;
using Melody.BusinessLayer.Requests.Upload;
using Melody.DataLayer.Models;
using Melody.Shared;
using Melody.Shared.Utils;

namespace Melody.BusinessLayer.Mappings
{
    public class AudioBookMapping : Mapping
    {
        public AudioBookMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<AudioBook, AudioBookDto>()
               .ReverseMap();

            CreateMap<UploadAudioRequest, AudioBookDto>()
                .ForMember(dto => dto.Title, mem => mem
                    .MapFrom(request => request.Data.Title))
                .ForMember(dto => dto.Author, mem => mem
                    .MapFrom(request => request.Data.Author))
                .ForMember(dto => dto.PublishedAt, mem => mem
                    .MapFrom(_ => DateTime.UtcNow))
                .ForMember(dto => dto.Description, mem => mem
                    .MapFrom(request => request.Data.Description))
                .ForMember(dto => dto.DurationInMs, mem => mem
                    .MapFrom(request => GetAudioDuration(request)))
                .ForMember(dto => dto.Filename, mem => mem
                    .MapFrom(request => request.File.FileName))
                .ForMember(dto => dto.AudioBookCollectionId, mem => mem
                    .MapFrom(request => request.Data.CollectionId))
                .ForMember(dto => dto.CreatorId, mem => mem
                    // first user in database
                    // TODO: change later
                    .MapFrom(_ => new Guid("6ecb9c55-4584-4d3f-abe7-f9ecd5450135")));

            CreateMap<AudioBookDto, CreateAudioBookRequest>();
        }

        private double GetAudioDuration(UploadAudioRequest request)
        {
            if (request.File is not null)
            {
                if (request.File.ContentType == "audio/wav" || request.File.ContentType == "audio/wave")
                {
                    using (var stream = request.File.OpenReadStream())
                    {
                        return WavUtils.GetAudioDuration(stream);
                    }
                }
                else
                {
                    using (var stream = request.File.OpenReadStream())
                    {
                        return Mp3Utils.GetAudioDuration(stream);
                    }
                }
            }

            return 0;
        }
    }
}
