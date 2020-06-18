using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Models
{
    public class Championship
    {
        public int idChampionship { get; set; }

        public string officialName { get; set; }

        public int year { get; set; }

        public ICollection<Championship_Team> championship_Teams { get; set; }
    }
}
