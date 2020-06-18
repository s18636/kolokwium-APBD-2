using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Configurations
{
    public class ChampionshipTeamEfConfiguration : IEntityTypeConfiguration<Championship_Team>
    {
        public void Configure(EntityTypeBuilder<Championship_Team> builder)
        {
            builder.HasKey(e => e.idTeam);
            builder.HasKey(e => e.idChampionship);
        }
    }
}
