myApp.controller('libraryController', function ($scope, $routeParams, libraryService) {

    $scope.libraryItems = [];

    function getlibraryItems() {
        libraryService.getLibrary().then(function (response) {
            const libItems = response.data;
            const libItemsWithQuantity = [];

            libItems.forEach(function (item) {
                const existingItem = libItemsWithQuantity.find((libItem) => libItem.GameId === item.GameId);
                if (existingItem) {
                    existingItem.quantity++;
                } else {
                    item.quantity = 1;
                    libItemsWithQuantity.push(item);
                }
            });

            $scope.libraryItems = libItemsWithQuantity;
        });
    }

    getlibraryItems();
});

