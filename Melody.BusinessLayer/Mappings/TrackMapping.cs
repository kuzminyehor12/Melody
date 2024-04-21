using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Tracks;
using Melody.BusinessLayer.Requests.Upload;
using Melody.DataLayer.Models;
using Melody.Shared;
using Melody.Shared.Utils;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melody.BusinessLayer.Mappings
{
    public class TrackMapping : Mapping
    {
        public TrackMapping() : base()
        {

        }
        protected override void RegisterMapping()
        {
            CreateMap<Track, TrackDto>()
               .ReverseMap();

            CreateMap<UploadAudioRequest, TrackDto>()
                .ForMember(dto => dto.Title, mem => mem
                    .MapFrom(request => request.Data.Title))
                .ForMember(dto => dto.Author, mem => mem
                    .MapFrom(request => request.Data.Author))
                .ForMember(dto => dto.Filename, mem => mem
                    .MapFrom(request => request.File.FileName))
                .ForMember(dto => dto.PublishedAt, mem => mem
                    .MapFrom(_ => DateTime.UtcNow))
                .ForMember(dto => dto.AlbumId, mem => mem
                    .MapFrom(request => request.Data.CollectionId))
                .ForMember(dto => dto.GenreIds, mem => mem
                    .MapFrom(request => request.Data.GenreIds.Select(id => new Guid(id))))
                .ForMember(dto => dto.DurationInMs, mem => mem
                    .MapFrom(request => GetAudioDuration(request)))
                .ForMember(dto => dto.CreatorId, mem => mem
                    // first user in database
                    // TODO: change later
                    .MapFrom(_ => new Guid("6ecb9c55-4584-4d3f-abe7-f9ecd5450135")));

            CreateMap<TrackDto, CreateTrackRequest>();

            CreateMap<CreateTrackRequest, Track>()
                .ForMember(track => track.Genres, mem => mem
                    .MapFrom(request => request.GenreIds.Select(id => new Genre { Id = id })));
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
