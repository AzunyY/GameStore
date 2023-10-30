using gmstore1.Models.Data.Repositories;
using gmstore1.Models.DTO;
using System.Collections.Generic;

namespace gmstore1.Services
{
    public class WishListService
    {
        private readonly GamesRepository _gameRepository;
        private readonly WishListGamesRepository _wishListRepository;

        public WishListService()
        {
            _gameRepository = new GamesRepository(DatabaseContext.Create());
            _wishListRepository = new WishListGamesRepository(DatabaseContext.Create());
        }

        public void AddToWishList(int gameId)
        {
            _wishListRepository.AddWishList(gameId);
        }

        public object GetAllGamesInWishlistt()
        {

            var items = _wishListRepository.GetGamesInWishlist();
            var gamesInCart = new List<GameDto>();

            foreach (var item in items)
            {
                var game = _gameRepository.GetGameById(item.getGameId());
                if (game != null)
                {
                    gamesInCart.Add(game.toDto());
                }
            }

            return gamesInCart;
        }
    }
}