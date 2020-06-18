using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Configurations
{
    public class PlayersEfConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> builder)
        {
            builder
           .HasKey(e => e.idPlayer); //[Key]


            var dictStudies = new List<Player>();
            dictStudies.Add(new Player { idPlayer = 1, firstName = "Maciej", lastName = "Nowak",dateOfBirth = "01-01-1998" });
            dictStudies.Add(new Player { idPlayer = 2, firstName = "Adam", lastName = "Jaki",dateOfBirth = "01-02-1998" });
            

            builder
                        .HasData(dictStudies);
        }
    }
}
