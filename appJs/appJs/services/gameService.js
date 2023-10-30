myApp.service('gameService', ['$http', '$q', function ($http, $q) {
    this.getGames = function (page) {
        console.log(page);
        var url = 'https://localhost:44368/api/games/' + page;
        return $http.get(url)
            .then(function (response) {
                return response.data;
            })
            .catch(function (error) {
                console.error('Error getting games: ', error);
                throw error;
            });
    };


    this.getGameData = function (gameId) {
        return $http.get('https://localhost:44368/api/games/get/' + gameId)
            .then(function (response) {
                console.log(response.data);
                return response.data;
            })
            .catch(function (error) {
                throw error;
            });
    };

    this.getHighlightGames = function () {
        return this.getGames(0)
            .then(function (games) {
                return games.slice(0, 4);
            });
    };
}]);
