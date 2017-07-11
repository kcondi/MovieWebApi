angular.module('app').controller('ActorsController',
    function($scope, $state, $stateParams, actorsRepository) {

        actorsRepository.getActorDetails($stateParams.id).then(function(actor) {
            $scope.chosenActor = actor.data;
        });
    });