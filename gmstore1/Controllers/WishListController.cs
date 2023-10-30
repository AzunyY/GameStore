using gmstore1.Services;
using System.Web.Http;

namespace gmstore1.Controllers
{
    [RoutePrefix("api/wishList")]
    public class WishListController : ApiController
    {
        private readonly WishListService _wishListService;
        public WishListController()
        {
            _wishListService = new WishListService();
        }
       
        [HttpPost]
        [Route()]
        public IHttpActionResult AddGameToWishList([FromBody] int gameId)
        {

            if (gameId != 0)
            {
               _wishListService.AddToWishList(gameId);
               return Ok();
            }
            else
            {
                return BadRequest("Invalid game data");
            }
        }

        [HttpGet]
        [Route("games")]
        public IHttpActionResult GetGamesInWishList()
        {
            var games = _wishListService.GetAllGamesInWishlistt();
            return Json(games);
        }
    }
}