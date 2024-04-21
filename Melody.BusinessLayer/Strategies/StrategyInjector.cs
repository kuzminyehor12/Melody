using AutoMapper;
using Melody.BusinessLayer.Interfaces;

namespace Melody.BusinessLayer.Strategies
{
    public class StrategyInjector
    {
        private readonly Lazy<ITrackService> _trackService;
        private readonly Lazy<IAlbumService> _albumService;
        private readonly Lazy<IPodcastService> _podcastService;
        private readonly Lazy<IAudioBookService> _audioBookService;
        private readonly Lazy<IAudioBookCollectionService> _audioBookCollectionService;
        private readonly IMapper _mapper;

        public Lazy<ITrackService> TrackService => _trackService;

        public Lazy<IAlbumService> AlbumService => _albumService;

        public Lazy<IPodcastService> PodcastService => _podcastService;

        public Lazy<IAudioBookService> AudioBookService => _audioBookService;

        public Lazy<IAudioBookCollectionService> AudioBookCollectionService => _audioBookCollectionService;

        public IMapper Mapper => _mapper;

        public StrategyInjector(
            IMapper mapper, 
            ITrackService trackService, 
            IAlbumService albumService, 
            IPodcastService podcastService, 
            IAudioBookService audioBookService, 
            IAudioBookCollectionService audioBookCollectionService)
        {
            _mapper = mapper;
            _trackService = new Lazy<ITrackService>(trackService);
            _albumService = new Lazy<IAlbumService>(albumService);
            _podcastService = new Lazy<IPodcastService>(podcastService);
            _audioBookService = new Lazy<IAudioBookService>(audioBookService);
            _audioBookCollectionService = new Lazy<IAudioBookCollectionService>(audioBookCollectionService);
        }
    }
}
