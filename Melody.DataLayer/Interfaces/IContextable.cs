using Microsoft.EntityFrameworkCore;

namespace Melody.DataLayer.Interfaces
{
    public interface IContextable
    {
        public void AttachContext(DbContext dbContext);
    }
}
