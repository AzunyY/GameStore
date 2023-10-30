myApp.controller('wishListController', function ($scope, $routeParams, wishListService) {
    $scope.addToWishlist = function (gameId) {
        wishListService.addToWishlist(gameId)
            .then(function () {
                console.log('Successfully added game to wishlist.');
            })
            .catch(function (error) {
                console.error('Error adding game to wishlist.', error);
            });
    };

    $scope.wishlistItems = [];

    function getWishlistItems() {
        wishListService.getWishList().then(function (response) {
            const cartItems = response.data;
            const cartItemsWithQuantity = [];

            cartItems.forEach(function (item) {
                const existingItem = cartItemsWithQuantity.find((cartItem) => cartItem.GameId === item.GameId);
                if (existingItem) {
                    existingItem.quantity++;
                } else {
                    item.quantity = 1;
                    cartItemsWithQuantity.push(item);
                }
            });

            $scope.wishlistItems = cartItemsWithQuantity;
        });
    }

    getWishlistItems();
});
