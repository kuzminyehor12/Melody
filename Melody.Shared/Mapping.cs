using AutoMapper;

namespace Melody.Shared
{
    public abstract class Mapping : Profile
    {
        protected Mapping()
        {
            RegisterMapping();
        }

        protected abstract void RegisterMapping();
    }
}
