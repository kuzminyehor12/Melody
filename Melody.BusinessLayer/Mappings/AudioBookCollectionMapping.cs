using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Albums;
using Melody.BusinessLayer.Requests.AudioBookCollections;
using Melody.BusinessLayer.Requests.Upload;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Mappings
{
    public class AudioBookCollectionMapping : Mapping
    {
        public AudioBookCollectionMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<AudioBookCollection, AudioBookCollectionDto>()
                .ReverseMap();

            CreateMap<UploadAudioRequest, AudioBookCollectionDto>()
                .ForMember(dto => dto.Title, mem => mem
                    .MapFrom(request => request.Data.Title))
                .ForMember(dto => dto.PublishedAt, mem => mem
                    .MapFrom(_ => DateTime.UtcNow))
                .ForMember(dto => dto.Description, mem => mem
                    .MapFrom(request => request.Data.Description));

            CreateMap<AudioBookCollectionDto, CreateAudioBookCollectionRequest>();

            CreateMap<CreateAudioBookCollectionRequest, AudioBookCollection>();
        }
    }
}
