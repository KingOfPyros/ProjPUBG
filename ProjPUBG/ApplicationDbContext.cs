using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace ProjPUBG
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<ContentAdmin> ContentAdmins { get; set; }
        public DbSet<Post> Posts { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
