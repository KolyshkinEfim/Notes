using learnASP.NET_CORE_mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace learnASP.NET_CORE_mvc.Data
{
    public class dbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public dbContext(DbContextOptions<dbContext> options) : base(options)
        {

        }
    }
}
