﻿using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Podcasts;
using Melody.Shared;

namespace Melody.BusinessLayer.Interfaces
{
    public interface IPodcastService
    {
        Task<Result> AddAsync(CreatePodcastRequest request, CancellationToken cancellationToken = default);

        Task<Result> RemoveAsync(RemovePodcastRequest request, CancellationToken cancellationToken = default);
    }
}
