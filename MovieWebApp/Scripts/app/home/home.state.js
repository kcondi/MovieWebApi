angular.module('app').config(function($stateProvider) {
    $stateProvider
        .state('home',
        {
            url: '/',
            templateUrl: '/Scripts/app/home/home.template.html'
        });
});