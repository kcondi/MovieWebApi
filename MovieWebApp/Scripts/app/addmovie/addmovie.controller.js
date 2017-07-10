angular.module('app').controller('AddMovieController',
    function($scope, $state, moviesRepository) {
        $scope.isGenreAdded = false;
        $scope.isDirectorAdded = false;
        $scope.isLoaded = false;
        $scope.actors = [];

        moviesRepository.getActorsGenresDirectors().then(function (allInfo) {
            $scope.allActors = allInfo.data.Actors;
            $scope.allDirectors = allInfo.data.Directors;
            $scope.allGenres = allInfo.data.Genres;
            $scope.isLoaded = true;
        });

        $scope.addActor = function(actor) {
            $scope.actors.push(actor);
            $scope.allActors.splice($scope.allActors.indexOf(actor), 1);
        }

        $scope.addGenre = function(genre) {
            $scope.genre = genre;
            $scope.isGenreAdded = true;
        }

        $scope.addDirector = function(director) {
            $scope.director = director;
            $scope.isDirectorAdded = true;
        }

        $scope.addNewMovie = function() {
            var newMovie = {
                Title: $scope.title,
                Year: $scope.year,
                Hashtag: $scope.hashtag,
                Genre: $scope.genre,
                Director: $scope.director,
                Actors: $scope.actors
            };
            moviesRepository.addMovie(newMovie).then(function () {
                $scope.movies.push(newMovie);
                $state.go('movies');
            });
        }
    });