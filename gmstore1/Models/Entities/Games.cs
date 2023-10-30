using gmstore1.Models.DTO;
using PetaPoco;
using System;

namespace gmstore1.Models.Entities
{
    [PrimaryKey("GamesId", AutoIncrement = true)]
    public class Games
    {
        public Games() { }

        [Column]
        private int gamesId { get; set; }
        [Column]
        private string name { get; set; }
        [Column]
        private int ESRB { get; set; }
        [Column]
        private double price { get; set; }
        [Column]
        private int year { get; set; }
        [Column]
        private string Genre { get; set; }
        [Column]
        private string Image { get; set; }
        [Column]
        private string Platforms { get; set; }
       

        public Games(string name, int ESRB, double price, int year, string Genres,string Platforns, string image)
        {
            this.name = name;
            this.year = year;
            this.ESRB = ESRB;
            this.price = price;
            this.Genre = Genres;
            this.Platforms = Platforns;
            this.Image = image;
        }

        public double getGameId()
        {
            return this.gamesId;
        }

        public GameDto toDto()
        {
            var gameDtos = new GameDto
            {
                GameId = this.gamesId,
                Title = this.name,
                ESBR = this.ESRB,
                Price = this.price,
                Genres = this.Genre,
                Platforms = this.Platforms,
                Image = this.Image,
                Year = this.year
            };

            return gameDtos;
        }
    }
}