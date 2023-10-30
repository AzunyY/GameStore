
namespace gmstore1.Models.DTO
{
    public class GameDto
    {
        public GameDto() { }
        public int GameId { get; set; }
        public string Title { get; set; }
        public int ESBR { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Genres { get; set; }
        public string Platforms { get; set; }
        public int Year { get; set; }
    }
}