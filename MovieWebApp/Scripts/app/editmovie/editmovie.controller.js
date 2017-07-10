angular.module('app').controller('AddMovieController',
    function ($scope, $state, $q, moviesRepository) {
        $scope.isGenreAdded = false;
        $scope.isDirectorAdded = false;
        $scope.isLoaded = false;
        $scope.actors = [];

        var allDbInfo = moviesRepository.getActorsGenresDirectors().then(function (allInfo) {
            $scope.allActors = allInfo.data.Actors;
            $scope.allDirectors = allInfo.data.Directors;
            $scope.allGenres = allInfo.data.Genres;
        });

        var allMovieInfo = moviesRepository.getMovieDetails($stateParams.id).then(function (movieDetails) {
            $scope.chosenMovie = movieDetails.data;
            $scope.actors = movieDetails.data.Actors;
            $scope.director = movieDetails.data.Director;
            $scope.genre = moviesRepository.data.Genre;
            if ($scope.director)
                $scope.isDirectorAdded = true;
            if ($scope.genre)
                $scope.isGenreAdded = true;
        });

        $q.all([allDbInfo, allMovieInfo]).then(function() {
            $scope.isLoaded = true;
        });

        $scope.addActor = function (actor) {
            $scope.actors.push(actor);
            $scope.allActors.splice($scope.allActors.indexOf(actor), 1);
        }

        $scope.removeActor=function(actor) {
            $scope.actors.splice($scope.actors.indexOf(actor), 1);
        }

        $scope.addGenre = function (genre) {
            $scope.genre = genre;
            $scope.isGenreAdded = true;
        }

        $scope.removeGenre = function() {
            $scope.genre = null;
            $scope.isGenreAdded = false;
        }

        $scope.addDirector = function (director) {
            $scope.director = director;
            $scope.isDirectorAdded = true;
        }

        $scope.removeDirector = function() {
            $scope.director = null;
            $scope.isDirectorAdded = false;
        }

        $scope.editMovie = function () {
            var editedMovie = {
                Title: $scope.title,
                Year: $scope.year,
                Hashtag: $scope.hashtag,
                Genre: $scope.genre,
                Director: $scope.director,
                Actors: $scope.actors
            };
            moviesRepository.editMovie(editedMovie).then(function () {
                $state.go('movies', {}, { reload: true });
            });
        }
    });