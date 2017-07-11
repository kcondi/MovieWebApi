angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('addmovielist',
            {
                parent: 'movielists',
                url: '/add',
                controller: 'AddMovieListController',
                templateUrl: '/Scripts/app/addmovielist/addmovielist.template.html'
            });
});