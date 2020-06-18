using kolos_2_cw.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace kolos_2_cw.Models
{
    public class PlayersDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Player_Team> Player_Team { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Championship> Championships { get; set; }

        public DbSet<Championship_Team> Championship_Team { get; set; }

        public PlayersDbContext() { }

        public PlayersDbContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new PlayersEfConfiguration());
            modelBuilder.ApplyConfiguration(new PlayerTeamEfConfiguration());
            modelBuilder.ApplyConfiguration(new TeamEfConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionshipsEfConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionshipTeamEfConfiguration());

          

        }
    }
}
