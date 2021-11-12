using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RankServer.Data
{
    public class RankDbContext : DbContext
    {
        public RankDbContext(DbContextOptions<RankDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Ranker> Rankers { get; set; }
    }
}
