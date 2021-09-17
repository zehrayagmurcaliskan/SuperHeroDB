﻿using Microsoft.EntityFrameworkCore;
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

            modelBuilder.Entity<SuperHero>().HasData(
               new SuperHero { Id = 1, FirstName = "Peter", LastName = "Parker", HeroName = "Spiderman", ComicId = 1 },
            new SuperHero { Id = 2, FirstName = "Bruce", LastName = "Wayne", HeroName = "Batman", ComicId = 2 }
               );
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
        
        public DbSet<Comic> Comics { get; set; }

    }
}
 