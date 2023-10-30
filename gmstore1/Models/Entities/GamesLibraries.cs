using PetaPoco;
using System;

namespace gmstore1.Models.Entities
{
    [TableName("GamesLibraries")]
    [PrimaryKey("GamesLibrariesId")]
    public class GamesLibraries
    {
        [Column("GamesLibrariesId")]
        private int GamesLibrariesId { get; set; }

        [Column("LibrariesId")]
        public int LibrariesId { get; set; }

        [Column("GamesId")]
        public int GameId { get; set; }

        public GamesLibraries() { }

        public GamesLibraries(int LibraryId, int GameId)
        {
            this.GameId = GameId;
            this.LibrariesId = LibraryId;
        }
        public int getGameId()
        {
            return this.GameId;
        }
    }
}