var myApp = angular.module('myApp', ['ngRoute', 'ui.bootstrap']);

myApp.config(function ($routeProvider) {
    $routeProvider
        .when('/home', {
            templateUrl: 'views/models/home.html',
            controller: 'homeController'
        })
        .when('/cart', {
            templateUrl: 'views/models/cart.html',
            controller: 'cartController'
        })
        .when('/library', {
            templateUrl: 'views/models/library.html',
            controller: 'libraryController'
        })
        .when('/wishlist', {
            templateUrl: 'views/models/wishlist.html',
            controller: 'wishListController'
        })
        .otherwise({
            redirectTo: '/home'
        });
});
