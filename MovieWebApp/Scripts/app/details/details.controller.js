angular.module('app').controller('MovieDetailsController',
    function ($scope, $state, $stateParams, moviesRepository) {
        $scope.isLoaded = false;

    moviesRepository.getMovieDetails($stateParams.id).then(function(movieDetails) {
        $scope.chosenMovie = movieDetails.data;
        $scope.isLoaded = true;
    });
})