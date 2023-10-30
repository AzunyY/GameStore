myApp.controller('cartController', ['$scope', '$uibModal', '$route', 'cartService', 'gameService', function ($scope, $uibModal, $route, cartService, gameService) {

    $scope.openModal = function () {
        var modalInstance = $uibModal.open({
            templateUrl: 'views/models/modalContent.html',
            controller: 'ModalController',
            size: 'md'
        });

        modalInstance.result.then(function (result) {
            if (result === 'OK') {
                console.log('Modal OK.');
            } else if (result === 'Cancel') {
                console.log('Modal Cancelled.');
            }
        });
    };

    var checkActiveRoute = function (route) {
        return $route.current && $route.current.originalPath === route;
    };

    $scope.$on('$routeChangeSuccess', function () {
        $scope.isCartActive = checkActiveRoute('/cart');
        $scope.isHomeActive = checkActiveRoute('/home');
        $scope.isLibraryActive = checkActiveRoute('/library');
        $scope.isWishlistActive = checkActiveRoute('/wishlist');
    });

    $scope.getTotalItemsInCart = function () {
        var totalItems = 0;
        for (var i = 0; i < $scope.cartItems.length; i++) {
            totalItems += $scope.cartItems[i].quantity;
        }
        return totalItems;
    };

    $scope.cartItems = cartService.getCartItems();

    $scope.addToCart = function (game) {
        if (game) {
            cartService.addToCart(game);
        } else {
            console.error('Game not found:', game.GameId);
        }
    }

    $scope.removeFromCart = function (gameId) {
        cartService.removeFromCart(gameId);
        $scope.cartItems = cartService.getCartItems();
    };

    $scope.removeAllFromCart = function (gameId) {
        cartService.removeAllFromCart(gameId);
        $scope.cartItems = cartService.getCartItems();
    };

    $scope.showForm = false;

    $scope.showCheckoutForm = function () {
        $scope.showForm = true;
    }

    $scope.$on('cartCleared', function () {
        $scope.cartItems = cartService.getCartItems();
    });
}]);
