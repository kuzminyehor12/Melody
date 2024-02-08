﻿using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class TrackMapping : Mapping
    {
        public TrackMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<TrackEntity, Track>()
                .ReverseMap();
        }
    }
}
