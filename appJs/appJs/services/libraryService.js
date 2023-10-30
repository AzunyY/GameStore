myApp.factory('libraryService', function ($http) {
    var service = {
        addItemsToLibrary: function (gameIds) {
            console.log(gameIds);
            return $http.post('https://localhost:44368/api/library', gameIds);
        },
        getLibrary: function () {
            return $http.get('https://localhost:44368/api/library/items');
        },
        
    };
    return service;
}); 