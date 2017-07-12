angular.module('app').filter('onlyFavoritesFilter',
    function (localStorageService) {
        return function (movies, isCheckboxChecked) {
            if (isCheckboxChecked) {
                var onlyFavorites = [];
                var currentFavorites =
                    angular.fromJson(localStorageService.get("favoritedMovies"));
                angular.forEach(movies,
                    function(movie) {
                        if (currentFavorites.indexOf(movie.Id) !== -1)
                            onlyFavorites.push(movie);
                    });
                return onlyFavorites;
            } else
                return movies;
        }
    });