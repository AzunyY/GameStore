myApp.factory('wishListService', function ($http) {
    var service = {
        addToWishlist: function (gameId) {
            return $http.post('https://localhost:44368/api/wishList', gameId);
        },
        getWishList: function () {
            return $http.get('https://localhost:44368/api/wishList/games'); 
        }
    };
    return service;
});