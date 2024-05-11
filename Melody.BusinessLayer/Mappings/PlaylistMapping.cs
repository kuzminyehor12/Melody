using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Albums;
using Melody.BusinessLayer.Requests.Playlists;
using Melody.BusinessLayer.Requests.Upload;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Mappings
{
    public class PlaylistMapping : Mapping
    {
        public PlaylistMapping() : base()
        {

        }

        protected override void RegisterMapping()
        {
            CreateMap<Playlist, PlaylistDto>()
                .ReverseMap();

            CreateMap<CreatePlaylistRequest, Playlist>()
                .ForMember(playlist => playlist.Title, mem => mem
                    .MapFrom(request => request.Data.Title))
                .ForMember(playlist => playlist.PublishedAt, mem => mem
                    .MapFrom(_ => DateTime.UtcNow))
                .ForMember(playlist => playlist.Description, mem => mem
                    .MapFrom(request => request.Data.Description))
                .ForMember(playlist => playlist.IsPublic, mem => mem
                    .MapFrom(request => request.Data.IsPublic))
                .ForMember(playlist => playlist.Coversheet, mem => {
                    mem.PreCondition(request => request.File is not null);
                    mem.MapFrom(request => request.File.FileName);
                })
                .ForMember(playlist => playlist.Tags, mem => mem
                    .MapFrom(request => request.Data.TagIds.Select(id => new Tag { Id = new Guid(id) })));
        }
    }
}
