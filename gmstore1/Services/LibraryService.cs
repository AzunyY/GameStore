using gmstore1.Models.DTO;
using System.Collections.Generic;

namespace gmstore1.Services
{
    public class LibraryService
    {
        private readonly LibraryRepository _libRepository;
        private readonly GamesRepository _gameRepository;

        public LibraryService()
        {
            this._gameRepository = new GamesRepository(DatabaseContext.Create());
            this._libRepository = new LibraryRepository(DatabaseContext.Create());
        }

        public void AddToLibrary(int gameId)
        {
            _libRepository.AddLibItem(gameId);
        }

        public IEnumerable<GameDto> GetAllGamesInLib()
        {
            var libItems = _libRepository.GetGamesInLib();
            var gamesInLib = new List<GameDto>();

            foreach (var libItem in libItems)
            {
                var game = _gameRepository.GetGameById(libItem.getGameId());
                if (game != null)
                {
                    gamesInLib.Add(game.toDto());
                }
            }

            return gamesInLib;
        }
    }
}