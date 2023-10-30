using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gmstore1.Models.Entities
{
    [TableName("Wishlists")]
    [PrimaryKey("WishlistsId", AutoIncrement = true)]
    public class Wishlists
    {
  
        public Wishlists() { }

        [Column]
        private int WishlistsId { get; set; }
        [Column]
        private DateTime DateAdded { get; set; }
    }
}