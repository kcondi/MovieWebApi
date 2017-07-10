angular.module('app').service('moviesRepository',
    function($http) {

        function getAllMovies() {
            return $http.get('/movies');
        }

        function getMovieDetails(id) {
            return $http.get('/movies/details',
                {
                    params: {
                        id: id
                    }
                });
        }

        function deleteMovie(id) {
            return $http.delete('/movies/delete',
                {
                    params: {
                        id: id
                    }
                });
        }

        function getActorsGenresDirectors() {
            return $http.get('/movies/add');
        }

        function addMovie(movie) {
            return $http.post('/movies/add', movie);
        }

        return {
            getAllMovies: getAllMovies,
            getMovieDetails: getMovieDetails,
            deleteMovie: deleteMovie,
            getActorsGenresDirectors: getActorsGenresDirectors,
            addMovie: addMovie
        }
    });