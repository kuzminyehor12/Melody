﻿using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.DataLayer.Mappings
{
    public class GenreMapping : Mapping
    {
        public GenreMapping() : base()
        {
            
        }
        protected override void RegisterMapping()
        {
            CreateMap<GenreEntity, Genre>()
               .ReverseMap();
        }
    }
}
