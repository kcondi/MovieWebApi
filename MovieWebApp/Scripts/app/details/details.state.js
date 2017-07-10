angular.module('app').config(function($stateProvider) {
    $stateProvider
        .state('details',
            {
                parent:'movies',
                url: '/details/:id',
                controller: 'MovieDetailsController',
                templateUrl: '/Scripts/app/details/details.template.html'
            });
});