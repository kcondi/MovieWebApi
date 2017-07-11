angular.module('app').controller('MovieListDetailsController',
    function ($scope, $state, $stateParams, movieListsRepository) {
        $scope.isLoaded = false;

        movieListsRepository.getMovieListDetails($stateParams.id).then(function (movieListDetails) {
            $scope.chosenMovieList = movieListDetails.data;
            $scope.isLoaded = true;
        });
    });