using gmstore1.Models.DTO;
using gmstore1.Models.Entities;
using gmstore1.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace gmstore1.Controllers
{
    [RoutePrefix("api/games")]
    public class GamesController : ApiController
    {
        private readonly GamesService _gameService;
        public GamesController() {
            _gameService = new GamesService();
        }

        [HttpGet]
        [Route("{page:int}")]
        public IHttpActionResult GetGames(int page)
        {
            var games = _gameService.GetAllGames(page);
            return Json(games);
        }

        [HttpPost]
        public IHttpActionResult AddGame([FromBody] Games game)
        {   
            _gameService.AddGame(game);
            return Ok("Jogo adicionado com sucesso!");
        }

        [HttpGet]
        [Route("get/{gameId}")]
        public IHttpActionResult GetGameById(int gameId)
        {
            if (gameId >= 0)
            {
                var game = _gameService.GetGameById(gameId);
                if (game != null)
                {
                    return Json(game);
                }
            }
            return NotFound();
        }
    }
}
