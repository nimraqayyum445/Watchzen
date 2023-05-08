using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Watchzen.Model
{
    public class WatchesDbContext : DbContext
    {
        public WatchesDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
    => options.UseSqlite("Data Source=watches.db");

        public WatchesDbContext(DbContextOptions<WatchesDbContext> options)
            : base(options)
        {
        }
        public DbSet<Watches> Watches { get; set; }
    }
}
