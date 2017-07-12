angular.module('app').controller('MovieListsController', function ($scope, $state, movieListsRepository) {
    $scope.isLoaded = false;
    $scope.movieLists = null;
    $scope.genre = null;
    $scope.isGenreChosen = false;

    movieListsRepository.getAllMovieLists().then(function (allListsAndGenres) {
        $scope.movieLists = allListsAndGenres.data.MovieLists;
        $scope.allGenres = allListsAndGenres.data.Genres;
        $scope.isLoaded = true;
    });

    $scope.deleteMovieList = function (id) {
        $scope.movieLists.splice($scope.movieLists.findIndex(movie => movie.Id === id), 1);
        movieListsRepository.deleteMovieList(id);
    }

    $scope.chooseGenre = function (genre) {
        $scope.genre = genre;
        $scope.isGenreChosen = true;
    }

    $scope.randomMovieList = function(numberOfMovies) {
        movieListsRepository.addRandomList(numberOfMovies, $scope.genre).then(function(randomMovieList) {
            $state.go('movielists', {}, { reload: true });
        });
    }
})