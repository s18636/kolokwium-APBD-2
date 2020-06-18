using kolos_2_cw.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw
{
    public class EfChampionshipsDbService : IChampionshipsDbService
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
                                   .Where(p => p.idChampionship.Equals(idChampionship))
                                   .OrderByDescending(p => p.score)
                                   .ToListAsync();

            return null;

        }
    }
}