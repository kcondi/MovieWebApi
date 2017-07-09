angular.module('app').service('moviesRepository',
    function($http) {

        function getAllMovies() {
            return $http.get('/movies');
        }

        function getMovieDetails(id) {
            return $http.get('/movies/details/:id',
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

        return {
            getAllMovies: getAllMovies,
            getMovieDetails: getMovieDetails,
            deleteMovie: deleteMovie
        }
    });