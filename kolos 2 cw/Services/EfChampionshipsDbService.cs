using kolos_2_cw.Models;
using System.Collections.Generic;
using System.Data.Entity;
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
            var Teams = await _context.Teams
                                   .Include(m => m.championship_Teams)
                                   .
        }
    }
}