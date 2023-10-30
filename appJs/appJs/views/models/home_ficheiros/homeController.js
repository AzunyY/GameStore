myApp.controller('homeController', ['$scope', 'gameService', function ($scope, gameService) {
    gameService.getGames()
        .then(function (games) {
            $scope.games = games.map(function (game) {
                return {
                    Name: game.Title,
                    ESRB: game.ESBR,
                    Price: game.Price,
                    image: game.Image,
                };
            });
        })
        .catch(function (error) {
            console.error('Error getting games: ', error);
        });
}]);
