angular.module('app').controller('MovieListsController', function ($scope, movieListsRepository) {
    $scope.isLoaded = false;
    $scope.movieLists = null;

    movieListsRepository.getAllMovieLists().then(function (allMovieLists) {
        $scope.movieLists = allMovieLists.data;
        $scope.isLoaded = true;
    });

    $scope.deleteMovieList = function (id) {
        $scope.movieLists.splice($scope.movieLists.findIndex(movie => movie.Id === id), 1);
        movieListsRepository.deleteMovieList(id);
    }
})