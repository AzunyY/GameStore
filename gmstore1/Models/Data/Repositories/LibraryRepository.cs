using gmstore1.Models.Entities;
using gmstore1.Models.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;

namespace gmstore1.Services
{
    public class LibraryRepository : AbstractRepository<GamesLibraries>
    {
        public LibraryRepository(IDatabase db) : base(db)
        {
        }

        public void AddLibItem(int gameId)
        {
            string sql = "INSERT INTO GamesLibraries (LibrariesId, GamesId) VALUES (@0, @1)";
            _db.Execute(sql, 1, gameId);
        }

        internal IEnumerable<GamesLibraries> GetGamesInLib()
        {
            string sql = @"
            SELECT game.*
            FROM GamesLibraries libitem
            JOIN Games game ON libitem.GamesId = game.GamesId
            WHERE libitem.LibrariesId = @0";

            return _db.Query<GamesLibraries>(sql, 1);
        }
    }
}