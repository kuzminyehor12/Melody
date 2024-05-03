using Melody.BusinessLayer.DTOs;
using Melody.BusinessLayer.Interfaces;
using Melody.BusinessLayer.Requests.Search;
using Melody.Services.Interfaces;
using Melody.Shared.Enums;

namespace Melody.BusinessLayer.Services
{
    public class SearchService : ISearchService
    {
        private readonly ITrackService _trackService;
        private readonly IPodcastService _podcastService;
        private readonly IAudioBookService _audioBookService;
        private readonly IAlbumService _albumService;
        private readonly IPlaylistService _playlistService;
        private readonly IAudioBookCollectionService _audioBookCollectionService;
        private readonly IDeezerApiClient _deezerApiClient;

        public SearchService(
            IDeezerApiClient deezerApiClient,
            ITrackService trackService,
            IPodcastService podcastService,
            IAudioBookService audioBookService,
            IAlbumService albumService,
            IPlaylistService playlistService,
            IAudioBookCollectionService audioBookCollectionService)
        {
            _deezerApiClient = deezerApiClient;
            _trackService = trackService;
            _podcastService = podcastService;
            _audioBookService = audioBookService;
            _albumService = albumService;
            _playlistService = playlistService;
            _audioBookCollectionService = audioBookCollectionService;
        }

        public Task<IEnumerable<DisplayableItemDto>> GetDisplayableItemsAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<dynamic> SearchApiItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            var response = await _deezerApiClient.SearchItemsAsync(request.SearchString, cancellationToken);
            return response;
        }

        public async Task<IEnumerable<CollectionItemDto>> SearchCollectionDbItemAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            IEnumerable<CollectionItemDto> items = request.Type switch
            {
                SearchType.Album => await _albumService.GetBySearchStringAsync(request.SearchString, cancellationToken),
                SearchType.AudiobookCollection => await _audioBookCollectionService.GetBySearchStringAsync(request.SearchString, cancellationToken),
                _ => await _playlistService.GetBySearchStringAsync(request.SearchString, cancellationToken)
            };

            return items;
        }

        public async Task<IEnumerable<AudioItemDto>> SearchDbItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            IEnumerable<AudioItemDto> items = request.Type switch
            {
                SearchType.Podcast => await _podcastService.GetBySearchStringAsync(request.SearchString, cancellationToken),
                SearchType.Audiobook => await _audioBookService.GetBySearchStringAsync(request.SearchString, cancellationToken),
                _ => await _trackService.GetBySearchStringAsync(request.SearchString, cancellationToken)
            };

            return items;
        }
    }
}
