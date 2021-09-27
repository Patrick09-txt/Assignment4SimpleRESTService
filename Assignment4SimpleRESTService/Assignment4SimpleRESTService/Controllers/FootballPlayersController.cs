using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment4SimpleRESTService.Managers;
using ModelLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment4SimpleRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayersController : ControllerBase
    {
        private readonly ManageFootballPlayers mgr = new ManageFootballPlayers();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return mgr.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public bool Post([FromBody] FootballPlayer newFootballPlayer)
        {
            mgr.Create(newFootballPlayer);
            return true;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer fbPlayer)
        {
            mgr.Update(id, fbPlayer);
            return true;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            FootballPlayer footballPlayer = mgr.Get(id);
            mgr.Delete(id);
            return footballPlayer;
        }
    }
}
