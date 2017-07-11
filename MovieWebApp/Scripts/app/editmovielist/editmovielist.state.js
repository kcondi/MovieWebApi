angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('editmovielist',
            {
                parent: 'movielists',
                url: '/edit/:id',
                controller: 'EditMovieListController',
                templateUrl: '/Scripts/app/editmovielist/editmovielist.template.html'
            });
});