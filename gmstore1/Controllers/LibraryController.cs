using gmstore1.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace gmstore1.Controllers
{
    [RoutePrefix("api/library")]
    public class LibraryController : ApiController
    {
        private readonly LibraryService _libraryService;
        public LibraryController()
        {
            _libraryService = new LibraryService();
        }

        [HttpPost]
        [Route()]
        public IHttpActionResult AddGameToLib([FromBody] List<int> gameIds)
        {
            if (gameIds != null && gameIds.Count > 0)
            {
                foreach (var gameId in gameIds)
                {
                    _libraryService.AddToLibrary(gameId);
                }
                return Ok();
            }
            else
            {
                return BadRequest("Invalid game data");
            }
        }

        [HttpGet]
        [Route("items")]
        public IHttpActionResult GetGamesLib()
        {
            var games = _libraryService.GetAllGamesInLib();
            return Json(games);
        }
    }
}