angular.module('app').config(function($stateProvider) {
    $stateProvider
        .state('details',
            {
                url: '/details/:id',
                controller: 'MovieDetailsController',
                templateUrl: '/Scripts/app/details/details.template.html'
            });
});