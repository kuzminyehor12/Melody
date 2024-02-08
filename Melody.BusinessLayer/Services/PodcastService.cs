﻿using AutoMapper;
using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Podcasts;
using Melody.DataLayer.Infastructure;
using Melody.DataLayer.Models;
using Melody.Shared;

namespace Melody.BusinessLayer.Services
{
    public class PodcastService : WriteService, IPodcastService
    {
        public PodcastService(RepositoryContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<Result> AddAsync(CreatePodcastRequest request, CancellationToken cancellationToken = default)
        {
            var podcast = _mapper.Map<Podcast>(request);
            var result = await _context.Podcasts.CreateAsync(podcast, cancellationToken);
            return await SaveChangesAsync(result, cancellationToken);
        }

        public async Task<IEnumerable<PodcastDto>> GetByTopicAsync(GetPodcastByTopicRequest request, CancellationToken cancellationToken = default)
        {
            var podcasts = await _context.Podcasts.ArrayAsync(
                p => p.TopicId == request.TopicId,
                AllIncludeProperties(),
                cancellationToken);

            return podcasts.Select(_mapper.Map<PodcastDto>);
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
                $"{nameof(Podcast.Topic)}",
                $"{nameof(Podcast.Tags)}",
                $"{nameof(Podcast.Creator)}"
            };
        }
    }
}
