using System.Reflection;

namespace Melody.DataLayer.Mappings
{
    public static class DLAssembly
    {
        public static Assembly GetAssembly()
        {
            return typeof(DLAssembly).Assembly;
        }
    }
}
