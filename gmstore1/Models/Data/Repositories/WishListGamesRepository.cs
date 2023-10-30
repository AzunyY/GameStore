using gmstore1.Models.Entities;
using gmstore1.Models.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace gmstore1.Models.Data.Repositories
{
    public class WishListGamesRepository : AbstractRepository<GamesWishlists>
    {
  
        public WishListGamesRepository(IDatabase db) : base(db)
        {
        }

        internal void AddWishList(int gameId)
        {
            string sql = "INSERT INTO GamesWishlists (WishlistsId, GamesId) VALUES (@0, @1)";
            _db.Execute(sql, 1, gameId);
        }

        public IEnumerable<GamesWishlists> GetGamesInWishlist()
        {
            string sql = @"
            SELECT game.*
            FROM GamesWishlists item
            JOIN Games game ON item.GamesId = game.GamesId
            WHERE item.WishlistsId = @0";

            return _db.Query<GamesWishlists>(sql, 1);
        }
    }
}