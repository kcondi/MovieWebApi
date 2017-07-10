angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('addmovie',
            {
                parent: 'movies',
                url: '/add',
                controller: 'AddMovieController',
                templateUrl: '/Scripts/app/addmovie/addmovie.template.html'
            });
});