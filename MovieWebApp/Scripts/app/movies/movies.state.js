angular.module('app').config(function($stateProvider) {
    $stateProvider
        .state('movies',
            {
                url: '/movies',
                controller: 'MoviesController',
                templateUrl: '/Scripts/app/movies/movies.template.html'
            });
});