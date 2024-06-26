﻿using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Requests.Search;

namespace Melody.BusinessLayer.Interfaces
{
    public interface ISearchService
    {
        public Task<IEnumerable<AudioItemDto>> SearchDbItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default);

        public Task<IEnumerable<CollectionItemDto>> SearchCollectionDbItemAsync(SearchItemRequest request, CancellationToken cancellationToken = default);

        public Task<dynamic> SearchApiItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default);

        public Task<IEnumerable<DisplayableItemDto>> GetDisplayableItemsAsync(CancellationToken cancellationToken = default); // genres + topics + tags
    }
}
