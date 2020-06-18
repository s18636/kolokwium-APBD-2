using kolos_2_cw.Models;
using System.Collections.Generic;

namespace kolos_2_cw
{
    internal interface IChampionshipsDbService
    {
        public IEnumerable<Team> GetTeams();
    }
}