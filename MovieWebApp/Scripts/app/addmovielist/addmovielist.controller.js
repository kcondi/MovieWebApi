angular.module('app').controller('AddMovieListController',
    function ($scope, $state, movieListsRepository) {
        $scope.isLoaded = false;
        $scope.movies = [];

        movieListsRepository.getAllMovies().then(function (movies) {
            $scope.allMovies = movies.data;
            $scope.isLoaded = true;
        });

        $scope.addMovie = function (movie) {
            $scope.movies.push(movie);
            $scope.allMovies.splice($scope.allMovies.indexOf(movie), 1);
        }

        $scope.addNewMovieList = function() {
            var newMovieList = {
                Name: $scope.name,
                Movies: $scope.movies
            };
            movieListsRepository.addMovieList(newMovieList).then(function() {
                $state.go('movielists', {}, { reload: true });
            });
        }
    });