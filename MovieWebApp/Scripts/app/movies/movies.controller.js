angular.module('app').controller('MoviesController',
    function($scope, moviesRepository, localStorageService, getCurrentFavoritesService) {
        $scope.isLoaded = false;
        $scope.movies = [];
        $scope.favorites = [];
        $scope.isCheckboxChecked = false;

        var allMoviesPromise = moviesRepository.getAllMovies();

        allMoviesPromise.then(function(allMovies) {
            $scope.movies = allMovies.data;
            $scope.isLoaded = true;
            $scope.favorites = getCurrentFavoritesService.getFavorites();
        });

        $scope.deleteMovie = function(id) {
            $scope.movies.splice($scope.movies.findIndex(movie => movie.Id === id), 1);
            moviesRepository.deleteMovie(id);
            if ($scope.favorites.indexOf(id) !== -1) {
                $scope.favorites.splice($scope.favorites.indexOf(id), 1);
                localStorageService.set("favoritedMovies", $scope.favorites);
            }
        }

        $scope.search = function(searchtext) {
            moviesRepository.searchForMovies(searchtext).then(function(foundMovies) {
                if (!searchtext)
                    allMoviesPromise.then(function(allMovies) {
                        $scope.movies = allMovies.data;
                    });
                $scope.movies = foundMovies.data;
            });
        }

        $scope.isFavorited = function (movieId) {
            return ~$scope.favorites.indexOf(movieId);
        }

        $scope.favorite = function (movieToFavoriteId) {
            if (~~$scope.favorites.indexOf(movieToFavoriteId))
                $scope.favorites.push(movieToFavoriteId);
            localStorageService.set("favoritedMovies", $scope.favorites);
        }

        $scope.unfavorite = function(movieToUnfavoriteId) {
            $scope.favorites.splice($scope.favorites.indexOf(movieToUnfavoriteId), 1);
            localStorageService.set("favoritedMovies", $scope.favorites);
        }

        $scope.changeChecked = function() {
            $scope.isCheckboxChecked = !$scope.isCheckboxChecked;
        }
    });