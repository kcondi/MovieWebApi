angular.module('app').controller('MoviesController', function($scope, moviesRepository) {
    $scope.isLoaded = false;
    $scope.movies = null;

    moviesRepository.getAllMovies().then(function(allMovies) {
        $scope.movies = allMovies.data;
        $scope.isLoaded = true;
    });

    $scope.goToMovieDetails = function(id) {
        moviesRepository.getMovieDetails(id);
    }

    $scope.deleteMovie = function (id) {
        moviesRepository.deleteMovie(id);
        $scope.movies.splice($scope.movies.findIndex(movie => movie.Id === id), 1);
    }
})