angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('movielistdetails',
            {
                parent: 'movielists',
                url: '/details/:id',
                controller: 'MovieListDetailsController',
                templateUrl: '/Scripts/app/movielistdetails/movielistdetails.template.html'
            });
});