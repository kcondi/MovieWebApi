angular.module('app').service('getCurrentFavoritesService',
    function (localStorageService) {
        this.getFavorites = function () {
            return angular.fromJson(localStorageService.get("favoritedMovies"));
        }
    });