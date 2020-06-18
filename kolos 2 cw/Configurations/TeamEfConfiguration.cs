using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Configurations
{
    public class TeamEfConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(e => e.idTeam);

            var teams = new List<Team>();
            teams.Add(new Team { idTeam = 1, teamName = "borsuki", maxAge = 32});
            teams.Add(new Team { idTeam = 2, teamName = "konie", maxAge = 31});

            builder.HasData(teams);
            
        }
    }
}
