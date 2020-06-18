using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolos_2_cw.Controllers
{
    [Route("api/musician")]
    [ApiController]
    public class TeamsControler : ControllerBase
    {


        private readonly EfChampionshipsDbService _dbService;
        public TeamsControler(EfChampionshipsDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> getTeams(int id)
        {


        

        }
    }
}
