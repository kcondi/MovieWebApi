angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('editmovie',
            {
                parent: 'movies',
                url: '/edit/:id',
                controller: 'EditMovieController',
                templateUrl: '/Scripts/app/editmovie/editmovie.template.html'
            });
});