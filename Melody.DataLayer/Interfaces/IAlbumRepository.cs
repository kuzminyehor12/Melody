using Melody.DataLayer.EFCore.Entities;
using Melody.DataLayer.Models;

namespace Melody.DataLayer.Interfaces
{
    public interface IAlbumRepository : IRepository<Album, AlbumEntity>
    {
    }
}
