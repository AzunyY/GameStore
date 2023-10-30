myApp.controller('ModalController', ['$scope', '$uibModalInstance', 'libraryService', 'cartService', '$rootScope', function ($scope, $uibModalInstance, libraryService, cartService, $rootScope) {
    $scope.customerData = {};
    $scope.ok = function () {
        if ($scope.customerData.name && $scope.customerData.address && $scope.customerData.phone) {
            var gameIds = cartService.getCartItems().map((item) => item.GameId);
            libraryService.addItemsToLibrary(gameIds);
            $uibModalInstance.close('OK');
            cartService.clearCart();
            $rootScope.$broadcast('cartCleared');
        } else {
            $uibModalInstance.dismiss('Cancel');
        }
    };

    $scope.cancel = function () {
        $uibModalInstance.dismiss('Cancel');
    };
}]);
