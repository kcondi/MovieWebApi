angular.module('app').controller('MovieDetailsController', function($scope, moviesRepository) {
    $scope.isLoaded = false;

    moviesRepository.getMovieDetails().then(function(movieDetails) {
        $scope.chosenMovie = movieDetails;
        $scope.isLoaded = true;
    });
})