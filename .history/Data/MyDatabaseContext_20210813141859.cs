using Microsoft.EntityFrameworkCore;

namespace DotNetAzure.Data
{
   public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetAzure.Models.Models.Todo> Todo { get; set; }
    }
}