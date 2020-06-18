using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Models
{
    public class Player_Team
    {
        
        public int idPlayer { get; set; }

     
        public int idTeam { get; set; }

        public int numOnShirt { get; set; }

        public string comment { get; set; }

        public Player Player { get; set; }

        public Team Team { get; set; }
    }
}
