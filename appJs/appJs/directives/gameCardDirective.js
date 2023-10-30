myApp.directive('gameCardDirective', function () {
    return {
        restrict: 'E',
        templateUrl: 'scripts/game-item.html',
        scope: {
            game: '=',
            showWishlistButton: '=',
            showRemoveButton: '=',
            showCartButton: '=',
            isCartView: '=',
            showAddButton: '=',
            showRemoveOneButton: '='
        },
    };
});
