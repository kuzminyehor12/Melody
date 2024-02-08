using Melody.DataLayer.Mappings;
using System.Reflection;

namespace Melody.BusinessLayer.Mappings
{
    public static class BLAssembly
    {
        public static Assembly GetAssembly()
        {
            return typeof(BLAssembly).Assembly;
        }
    }
}
