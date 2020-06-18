using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw
{
    internal class EfChampionshipsDbService : IChampionshipsDbService
    {

        private readonly PlayersDbContext _context;
        public EfChampionshipsDbService(PlayersDbContext context)
        {
            _context = context;
        }
        public async Task addPlayerToTeam(Player player, int idTeam)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Team>> GetTeams(int idChampionship)
        {
            var teams = await _context.Championship_Team
                                   .Where(x => x.idChampionship.Equals(idChampionship))
                                   .OrderByDescending(x => x.score)
                                   .ToListAsync();

            Dictionary<string, float> teamsDic = new Dictionary<string, float>();
            foreach (var team in teams)
            {
                teamsDic.Add(
                    _context.Teams.Single(x => x.idTeam.Equals(team.idTeam)).teamName,
                    team.score
                );
            }

            return

        }
    }
}