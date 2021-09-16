using Microsoft.EntityFrameworkCore;
using SuperHeroDB.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroDB.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comic>().HasData(
                new Comic { Name = "Marvel", Id = 1 },
                new Comic { Name = "DC", Id = 2 }
                );

            modelBuilder.Entity<Comic>().HasData(
               new Comic { Name = "Marvel", Id = 1 },
               new Comic { Name = "DC", Id = 2 }
               );
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        
        public DbSet<Comic> Comics { get; set; }

    }
}
 