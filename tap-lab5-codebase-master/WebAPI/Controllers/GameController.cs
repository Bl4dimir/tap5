using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebAPI.DTOs;


namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly MyDbContext _context;

        public GameController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GameDto>> GetGames()
        {
            var games = _context.Games.Select(game => new GameDto
            {
                Id = game.Id,
                Name = game.Name,
                SizeInGB = game.SizeInGB
            }).ToList();

            return Ok(games);
        }

    }
}
