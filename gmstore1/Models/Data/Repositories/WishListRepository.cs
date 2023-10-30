using gmstore1.Models.Entities;
using gmstore1.Models.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gmstore1.Models.Data.Repositories
{
    public class WishListRepository : AbstractRepository<Wishlists>
    {
        public WishListRepository(IDatabase db) : base(db)
        {
        }

        public void AddWishList(Wishlists wl)
        {
            Add(wl);
        }
    }
}