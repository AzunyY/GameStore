using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gmstore1.Models.Entities
{
    [PrimaryKey("GamesWishlistsId")]
    public class GamesWishlists
    {
        public GamesWishlists() { }

        [Column]
        private int GamesWishlistsId { get; set; }

        [Column]
        private int WishlistsId { get; set; }

        [Column]
        private int GamesId { get; set; }

        public GamesWishlists(int wishlistid, int gameid)
        {
            this.WishlistsId = wishlistid;
            this.GamesId = gameid;
        }

        public int getGameId()
        {
            return this.GamesId;
        }
    }
}