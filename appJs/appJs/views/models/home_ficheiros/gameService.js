myApp.service('gameService', ['$http', function ($http) {
    this.getGames = function () {
        return $http.get('https://localhost:44368/api/games')
            .then(function (response) {
                return response.data;
            })
            .catch(function (error) {
                console.error('Error getting games: ', error);
                throw error;
            });
    };
}]);

