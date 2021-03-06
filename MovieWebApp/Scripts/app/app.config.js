﻿angular.module('app').config(function($stateProvider, $locationProvider, $urlRouterProvider) {
    $locationProvider.html5Mode(true);
    $urlRouterProvider.otherwise('/');
});

angular.module('app').run(function (localStorageService) {
    if (!angular.fromJson(localStorageService.get("favoritedMovies")))
        localStorageService.set("favoritedMovies", angular.toJson([]));
});