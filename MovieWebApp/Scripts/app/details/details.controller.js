angular.module('app').controller('MovieDetailsController',
    function ($scope, $state, $stateParams, moviesRepository) {
    $scope.isLoaded = false;

    moviesRepository.getMovieDetails($stateParams.Id).then(function(movieDetails) {
        $scope.chosenMovie = movieDetails;
        $scope.isLoaded = true;
    });
})