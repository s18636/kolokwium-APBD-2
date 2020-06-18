using kolos_2_cw.Models;
using System.Collections.Generic;
using System.Linq;

namespace kolos_2_cw
{
    internal class EfChampionshipsDbService : IChampionshipsDbService
    {
        private readonly PlayersDbContext _context;
        public EfChampionshipsDbService(PlayersDbContext context)
        {
            _context = context;
        }

      
        public IEnumerable<Team> GetTeams()
        {
            return (IEnumerable<Team>)_context.Championships.ToList();
        }
    }
}