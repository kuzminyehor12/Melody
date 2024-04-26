﻿using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Podcasts;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Services.Interfaces;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class PodcastService : WriteService, IPodcastService
    {
        private readonly IFileStorageService _fileStorageService;
        public PodcastService(RepositoryContext context, IMapper mapper, IFileStorageService fileStorageService) : base(context, mapper)
        {
            _fileStorageService = fileStorageService;
        }

        public async Task<Result> AddAsync(CreatePodcastRequest request, CancellationToken cancellationToken = default)
        {
            var podcast = _mapper.Map<Podcast>(request);
            var result = await _context.Podcasts.CreateAsync(podcast, cancellationToken);
            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<IEnumerable<PodcastDto>> GetBySearchStringAsync(string searchString, CancellationToken cancellationToken)
        {
            var podcasts = await _context.Podcasts.ArrayAsync(
               p => p.Title.Contains(searchString) || p.Author.Contains(searchString) || p.Description.Contains(searchString),
               p => p.ListeningsCount,
               AllIncludeProperties(),
               true,
               cancellationToken);

            var dtos = podcasts.Select(_mapper.Map<PodcastDto>).ToList();

            foreach (var dto in dtos)
            {
                dto.DownloadUrl = await _fileStorageService.DownloadAsync(dto.Filename);
            }

            return dtos;
        }

        public async Task<Result> RemoveAsync(RemovePodcastRequest request, CancellationToken cancellationToken = default)
        {
            var result = await _context.Podcasts.DeleteAsync(p => p.Id == request.PodcastId, cancellationToken: cancellationToken);
            return await SaveChangesAsync(result, cancellationToken);
        }

        protected override IEnumerable<string> AllIncludeProperties()
        {
            return new List<string>
            {
                $"{nameof(Podcast.Creator)}",
                $"{nameof(Podcast.Followers)}"
            };
        }
    }
}
