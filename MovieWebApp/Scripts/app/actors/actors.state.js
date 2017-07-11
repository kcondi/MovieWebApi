angular.module('app').config(function ($stateProvider) {
    $stateProvider
        .state('actors',
            {
                url: '/actors/:id',
                controller: 'ActorsController',
                templateUrl: '/Scripts/app/actors/actors.template.html'
            });
});