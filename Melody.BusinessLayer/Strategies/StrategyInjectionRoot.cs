using AutoMapper;

namespace Melody.BusinessLayer.Strategies
{
    public abstract class StrategyInjectionRoot
    {
        protected readonly StrategyInjector _injector;
        protected IMapper Mapper => _injector.Mapper;

        protected StrategyInjectionRoot(StrategyInjector injector)
        {
            _injector = injector;
        }
    }
}
