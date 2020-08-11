using ExploreCalifornia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.dbcontext
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public IQueryable<MonthlySpecial> MonthlySpecials
        {
            get
            {
                return new[]
                {
                    new MonthlySpecial {
                        Key = "calm",
                        Name = "California Calm Package",
                        Type = "Day Spa Package",
                        Price = 250,
                    },
                    new MonthlySpecial {
                        Key = "desert",
                        Name = "From Desert to Sea",
                        Type = "2 Day Salton Sea",
                        Price = 350,
                    },
                    new MonthlySpecial {
                        Key = "backpack",
                        Name = "Backpack Cali",
                        Type = "Big Sur Retreat",
                        Price = 620,
                    },
                    new MonthlySpecial {
                        Key = "taste",
                        Name = "Taste of California",
                        Type = "Tapas & Groves",
                        Price = 150,
                    },
                }.AsQueryable();
            }
        }
        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
       
    }
}
