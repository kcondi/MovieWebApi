angular.module('app').controller('DirectorsController',
    function ($scope, $state, $stateParams, directorsRepository) {

        directorsRepository.getDirectorDetails($stateParams.id).then(function (director) {
            $scope.chosenDirector = director.data;
        });
    });