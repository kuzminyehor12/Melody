using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Albums;
using Melody.BusinessLayer.Requests.Tracks;
using Melody.BusinessLayer.Requests.Upload;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Mappings
{
    public class AlbumMapping : Mapping
    {
        public AlbumMapping() : base()
        {
            
        }

        protected override void RegisterMapping()
        {
            CreateMap<Album, AlbumDto>()
                .ReverseMap();

            CreateMap<UploadAudioRequest, AlbumDto>()
                .ForMember(dto => dto.Title, mem => mem
                    .MapFrom(request => request.Data.Title))
                .ForMember(dto => dto.Author, mem => mem
                    .MapFrom(request => request.Data.Author))
                .ForMember(dto => dto.CreatedAt, mem => mem
                    .MapFrom(_ => DateTime.UtcNow))
                .ForMember(dto => dto.Description, mem => mem
                    .MapFrom(request => request.Data.Description))
                .ForMember(dto => dto.CreatorId, mem => mem
                    // first user in database
                    // TODO: change later
                    .MapFrom(_ => new Guid("6ecb9c55-4584-4d3f-abe7-f9ecd5450135")));

            CreateMap<AlbumDto, CreateAlbumRequest>();

            CreateMap<CreateAlbumRequest, Album>();
        }
    }
}
