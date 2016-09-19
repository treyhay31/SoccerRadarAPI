using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoccerRadarAPI.Repositories;
using SoccerRadarAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SoccerRadarAPI.Controllers
{
    [Route("api/players")]
    public class PlayerController : Controller
    {
        public IReadOnlyRepository<Player> _playerRepository { get; set; }

        public PlayerController(IReadOnlyRepository<Player> playerRepository)
        {
            if (playerRepository == null)
            {
                throw new ArgumentNullException("player repository");
            }

            _playerRepository = playerRepository;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_playerRepository.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetPlayer")]
        public IActionResult Get(string id)
        {
            var player = _playerRepository.Find(id);

            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
