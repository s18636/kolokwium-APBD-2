using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace kolos_2_cw.Models
{
    public class Championship_Team
    {
        [ForeignKey("Team")]
        public int idTeam { get; set; }

        [ForeignKey("Championship")]
        public int idChampionship { get; set; }

        public float score { get; set; }
    }
}
