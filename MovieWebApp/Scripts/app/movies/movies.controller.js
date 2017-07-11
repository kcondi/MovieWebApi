angular.module('app').controller('MoviesController', function($scope, moviesRepository) {
    $scope.isLoaded = false;
    $scope.movies = null;

    var allMoviesPromise = moviesRepository.getAllMovies();

    allMoviesPromise.then(function (allMovies) {
        $scope.movies = allMovies.data;
        $scope.isLoaded = true;
    });

    $scope.deleteMovie = function (id) {
        $scope.movies.splice($scope.movies.findIndex(movie => movie.Id === id), 1);
        moviesRepository.deleteMovie(id);
    }

    $scope.search = function(searchtext) {
        moviesRepository.searchForMovies(searchtext).then(function(foundMovies) {
            if (!searchtext)
                allMoviesPromise.then(function (allMovies) {
                    $scope.movies = allMovies.data;
                });
            $scope.movies = foundMovies.data;
        });
    }
})