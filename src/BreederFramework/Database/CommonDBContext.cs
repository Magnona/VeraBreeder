using Microsoft.EntityFrameworkCore;

namespace BreederFramework.Database
{
    internal abstract class CommonDBContext : DbContext
    {

        private readonly string _tablePrefix;
    }
}
