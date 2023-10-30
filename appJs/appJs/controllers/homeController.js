myApp.controller('homeController', ['$scope', '$window', 'gameService', function ($scope, $window, gameService) {
    $scope.featuredGames = [];
    var scrollContainer = document.querySelector('.game-list-container');

    gameService.getHighlightGames()
        .then(function (highlightGames) {
            $scope.highlightGames = highlightGames;
            console.log(highlightGames);
        })
        .catch(function (error) {
            console.error('Error getting highlight games: ', error);
        });

    var start = 0;
    var loading = false;

    function loadMoreGames() {
        if (loading) return;

        loading = true;

        gameService.getGames(start)
            .then(function (moreGames) {
                $scope.featuredGames = $scope.featuredGames.concat(moreGames);
                console.log($scope.featuredGames);
                start ++;
                loading = false;
            })
            .catch(function (error) {
                console.error('Error getting featured games: ', error);
                loading = false;
            });
    };

    scrollContainer.addEventListener('scroll', function () {
        if ((window.innerHeight + window.scrollY) >= document.body.offsetHeight) {
            var scrollContainerHeight = scrollContainer.scrollHeight;
            var scrollContainerScrollTop = scrollContainer.scrollTop;
            var scrollContainerClientHeight = scrollContainer.clientHeight;

            if (scrollContainerScrollTop + scrollContainerClientHeight >= scrollContainerHeight) {
                loadMoreGames();
            }
        }
    });

    loadMoreGames();
}]);
