angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('movielists',
            {
                url: '/movielists',
                controller: 'MovieListsController',
                templateUrl: '/Scripts/app/movielists/movielists.template.html'
            });
});