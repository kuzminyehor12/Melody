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
            var items = Enumerable.Empty<CollectionItemDto>();

            switch (request.Type)
            {
                case SearchType.Album:
                    items = await _albumService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
                case SearchType.AudiobookCollection:
                    items = await _audioBookCollectionService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
                case SearchType.Playlist:
                    items = await _playlistService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
                default:
                    items = await _playlistService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
            }

            return items;
        }

        public async Task<IEnumerable<AudioItemDto>> SearchDbItemsAsync(SearchItemRequest request, CancellationToken cancellationToken = default)
        {
            var items = Enumerable.Empty<AudioItemDto>();

            switch (request.Type)
            {
                case SearchType.Track:
                    items = await _trackService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
                case SearchType.Podcast:
                    items = await _podcastService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
                case SearchType.Audiobook:
                    items = await _audioBookService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
                default:
                    items = await _audioBookService.GetBySearchStringAsync(request.SearchString, cancellationToken);
                    break;
            }

            return items;
        }
    }
}
