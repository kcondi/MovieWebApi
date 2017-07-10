angular.module('app').controller('EditMovieController',
    function ($scope, $state, $stateParams, moviesRepository) {
        $scope.isGenreAdded = false;
        $scope.isDirectorAdded = false;
        $scope.isLoaded = false;
        $scope.actors = [];

        moviesRepository.getActorsGenresDirectorsMovie($stateParams.id).then(function (allInfo) {
            $scope.allActors = allInfo.data.Actors;
            $scope.allDirectors = allInfo.data.Directors;
            $scope.allGenres = allInfo.data.Genres;
            $scope.chosenMovie = allInfo.data.Movie;
            $scope.title = allInfo.data.Movie.Title;
            $scope.year = allInfo.data.Movie.Year;
            $scope.hashtag = allInfo.data.Movie.Hashtag;
            $scope.actors = allInfo.data.Movie.Actors;
            $scope.director = allInfo.data.Movie.Director;
            $scope.genre = allInfo.data.Movie.Genre;
            if ($scope.director)
                $scope.isDirectorAdded = true;
            if ($scope.genre)
                $scope.isGenreAdded = true;
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
            $scope.chosenMovie.Genre.Name = genre.Name;
            $scope.isGenreAdded = true;
        }

        $scope.removeGenre = function() {
            $scope.genre = null;
            $scope.chosenMovie.Genre.Name = "";
            $scope.isGenreAdded = false;
        }

        $scope.addDirector = function (director) {
            $scope.director = director;
            $scope.chosenMovie.Director.Name = director.Name;
            $scope.isDirectorAdded = true;
        }

        $scope.removeDirector = function() {
            $scope.director = null;
            $scope.chosenMovie.Director.Name = "";
            $scope.isDirectorAdded = false;
        }

        $scope.editMovie = function () {
            var editedMovie = {
                Id: $scope.chosenMovie.Id,
                Title: $scope.title,
                Year: $scope.year,
                Hashtag: $scope.hashtag,
                Genre: $scope.genre,
                Director: $scope.director,
                Actors: $scope.actors
            };
            moviesRepository.editExistingMovie(editedMovie).then(function () {
                $state.go('movies', {}, { reload: true });
            });
        }
    });