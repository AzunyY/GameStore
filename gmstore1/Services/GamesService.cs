using gmstore1.Models.DTO;
using gmstore1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gmstore1.Services
{
    public class GamesService
    {
        private readonly GamesRepository _gameRepository;

        public GamesService()
        {
            _gameRepository = new GamesRepository(DatabaseContext.Create());
        }

        public void AddGame(Games game)
        {
            _gameRepository.AddGame(game);
        }

        public void DeleteGame(int gameId)
        {
            _gameRepository.DeleteGame(gameId);
        }

        public void UpdateGame(Games game)
        {
            _gameRepository.UpdateGame(game);
        }

        public GameDto GetGameById(int gameId)
        {
            return _gameRepository.GetGameById(gameId).toDto();
        }

        public List<GameDto> GetAllGames(int page)
        {
            int p = page;
            var games = _gameRepository.GetAllGames(page);
            var gamesInDB = new List<GameDto>();

            foreach (var game in games)
            {
                if (game != null)
                {
                    gamesInDB.Add(game.toDto());
                }
            }

            return gamesInDB;
        }
    }
}