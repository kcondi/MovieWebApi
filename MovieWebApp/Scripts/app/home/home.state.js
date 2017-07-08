angular.module('app').config(function($stateProvider) {
    $stateProvider
        .state('home',
        {
            url: '/',
            templateUrl: '/scripts/app/home/home.template.html'
        });
});