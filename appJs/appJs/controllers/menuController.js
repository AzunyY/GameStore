myApp.controller('menuController', ['$scope', '$location', '$route', function ($scope, $location, $route) {
    var checkActiveRoute = function (route) {
        return $route.current && $route.current.originalPath === route;
    };

    $scope.$on('$routeChangeSuccess', function () {
        $scope.isCartActive = checkActiveRoute('/cart');
        $scope.isHomeActive = checkActiveRoute('/home');
        $scope.isLibraryActive = checkActiveRoute('/library');
        $scope.isWishlistActive = checkActiveRoute('/wishlist');
    });
}]);

