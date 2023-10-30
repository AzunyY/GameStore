using gmstore1.Models.Entities;
using gmstore1.Models.Repositories;
using PetaPoco;
using System;
using System.Collections.Generic;

public class GamesRepository : AbstractRepository<Games>
{

    public GamesRepository(Database db) : base(db)
    {
    }

    public IEnumerable<Games> GetGamesByGenre(int genreId)
    {
        string sql = "SELECT * FROM Games WHERE GenresId = @0";
        return _db.Query<Games>(sql, genreId);
    }

    public IEnumerable<Games> GetGamesByPlatform(int platformId)
    {
        string sql = @"
            SELECT g.*
            FROM Games game
            JOIN Platforms gameplat ON game.GameId = gameplat.GameId
            WHERE gameplat.PlatformId = @0";

        return _db.Query<Games>(sql, platformId);
    }
    public void AddGame(Games game)
    {
        Add(game);
    }

    public void DeleteGame(int gameId)
    {
        Remove(gameId);
    }

    public void UpdateGame(Games game)
    {
        Update(game);
    }

    public IEnumerable<Games> GetHighlightGames()
    {
        string sql = "SELECT TOP 2 * FROM Games ORDER BY Year";
        return _db.Query<Games>(sql);
    }

    public Games GetGameById(int gameId)
    {
        int game = gameId;
        string sql = "SELECT * FROM Games WHERE GamesId = @0";
        return _db.SingleOrDefault<Games>(sql, gameId);
    }

    internal object GetGameById(object p)
    {
        throw new NotImplementedException();
    }
    public IEnumerable<Games> GetAllGames(int page)
    {
        int pageSize = 5;
        string sql = "SELECT * FROM Games ORDER BY Year OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY";
        return _db.Query<Games>(sql, new { Offset = page * pageSize, PageSize = pageSize });
    }

}

