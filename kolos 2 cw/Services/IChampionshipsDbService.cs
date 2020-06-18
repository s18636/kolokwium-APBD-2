using kolos_2_cw.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace kolos_2_cw
{
    internal interface IChampionshipsDbService
    {
        Task<IEnumerable<Team>> GetTeams(int idChampionship);
        Task addPlayerToTeam(Player player, int idTeam);
    }
}