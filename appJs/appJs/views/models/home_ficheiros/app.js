var myApp = angular.module('myApp', ['ngRoute']);

myApp.config(function ($routeProvider) {
    $routeProvider
        .when('/home', {
            templateUrl: 'views/models/home.html',
            controller: 'homeController'
        })
        .when('/games', { 
            templateUrl: 'views/models/games.html',
            controller: 'gamesController'
        })
        .otherwise({
            redirectTo: '/home'
        });
});

app.controller('homeController', ['$scope', 'gameService', function ($scope, GameService) {
    GameService.getHighlightGame()
        .then(function (game) {
            $scope.highlightGame = game;
        });

    GameService.getAllGames()
        .then(function (games) {
            $scope.games = games;
        });
}]);

app.service('gameService', ['$http', '$q', function ($http, $q) {
    this.getHighlightGame = function () {
        // Simulate API call for the highlight game
        var deferred = $q.defer();
        var highlightGame = {
            Name: 'Game of the Month',
            ESRB: 'E',
            Price: 49.99,
            Image: 'game-of-the-month.jpg'
        };
        deferred.resolve(highlightGame);
        return deferred.promise;
    };

    this.getAllGames = function () {
        // Simulate API call to get all games
        var deferred = $q.defer();
        var games = [
            {
                Name: 'Game 1',
                ESRB: 'T',
                Price: 29.99,
                Image: 'game1.jpg'
            },
            {
                Name: 'Game 2',
                ESRB: 'M',
                Price: 59.99,
                Image: 'game2.jpg'
            },
            {
                Name: 'Game 3',
                ESRB: 'E',
                Price: 39.99,
                Image: 'game3.jpg'
            }
        ];
        deferred.resolve(games);
        return deferred.promise;
    };
}]);
