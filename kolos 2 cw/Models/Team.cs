﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Models
{
    public class Team
    {
        public int idTeam { get; set; }

        public string teamName { get; set; }

        public int maxAge { get; set; }

        public ICollection<Championship_Team> championship_Teams { get; set; }

        public ICollection<Player_Team> Player_Teams { get; set; }

    }
}
