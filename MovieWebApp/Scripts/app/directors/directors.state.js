angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('directors',
            {
                url: '/directors/:id',
                controller: 'DirectorsController',
                templateUrl: '/Scripts/app/directors/directors.template.html'
            });
});