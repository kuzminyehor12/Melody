﻿using AutoMapper;
using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.EFCore.Infrastructure;
using Melody.DataLayer.Infrastructure;
using Melody.DataLayer.Interfaces;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Infastructure
{
    public class UserRepository : Repository<User, UserEntity>, IUserRepository
    {
        public UserRepository(MelodyDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        protected override Task<UserEntity> PopulateEntity(User model)
        {
            var entity = _mapper.Map<UserEntity>(model);
            return Task.FromResult(entity);
        }
    }
}
