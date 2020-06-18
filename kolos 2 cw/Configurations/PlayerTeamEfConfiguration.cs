using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Configurations
{
    public class PlayerTeamEfConfiguration : IEntityTypeConfiguration<Player_Team>
    {

        public void Configure(EntityTypeBuilder<Player_Team> builder)
        {
            builder.HasKey(e => e.idPlayer);
            builder.HasKey(e => e.idTeam);

            
        }
    }
}
