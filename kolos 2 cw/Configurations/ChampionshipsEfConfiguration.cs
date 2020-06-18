using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Configurations
{
    public class ChampionshipsEfConfiguration : IEntityTypeConfiguration<Championship>
    {
        public void Configure(EntityTypeBuilder<Championship> builder)
        {
            builder
                .HasKey(e => e.idChampionship);//[key]

            builder.HasMany(p => p.championship_Teams)
                 .WithOne(p => p.Championship)
                 .HasForeignKey(p => p.idChampionship);

            var dictStudies = new List<Championship>();
            dictStudies.Add(new Championship { idChampionship = 1, officialName = "zawody", year = 2020});
            dictStudies.Add(new Championship { idChampionship = 2, officialName = "liga", year = 2020});
            


            builder
                        .HasData(dictStudies);
        }
    }
}
