angular.module('app').controller('EditMovieListController',
    function ($scope, $state, $stateParams, movieListsRepository) {
        $scope.isLoaded = false;
        $scope.movies = [];

        movieListsRepository.getMoviesMovieList($stateParams.id).then(function (allInfo) {
            $scope.allMovies = allInfo.data.Movies;
            $scope.chosenMovieList = allInfo.data.MovieList;
            $scope.movies = allInfo.data.MovieList.Movies;
            $scope.name = allInfo.data.MovieList.Name;
            $scope.isLoaded = true;
        });

        $scope.addMovie = function (movie) {
            $scope.movies.push(movie);
            $scope.allMovies.splice($scope.allMovies.indexOf(movie), 1);
        }

        $scope.removeMovie = function (movie) {
            $scope.movies.splice($scope.movies.indexOf(movie), 1);
        }

        $scope.editMovieList = function () {
            var editedMovieList = {
                Id: $scope.chosenMovieList.Id,
                Name: $scope.name,
                Movies: $scope.movies
            };
            movieListsRepository.editExistingMovieList(editedMovieList).then(function () {
                $state.go('movielists', {}, { reload: true });
            });
        }
    });