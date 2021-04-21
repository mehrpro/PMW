using System.Data.Entity;
using PMW.Entities;

namespace PMW
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppConnectionString")
        {
            Database.SetInitializer<AppDbContext>(new CreateDatabaseIfNotExists<AppDbContext>());

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Machinery> Machineries { get; set; }

    }
}