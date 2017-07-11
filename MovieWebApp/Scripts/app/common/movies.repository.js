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

        function addMovie(newMovie) {
            return $http.post('/movies/add', newMovie);
        }

        function getActorsGenresDirectorsMovie(id) {
            return $http.get('/movies/edit',
                {
                    params: {
                        id: id
                    }
                });
        }

        function editExistingMovie(editedMovie) {
            return $http.post('/movies/edit', editedMovie);
        }

        function searchForMovies(searchtext) {
            return $http.get('/movies/search',
                {
                    params: {
                        searchtext: searchtext
                    }
                });
        }

        return {
            getAllMovies: getAllMovies,
            getMovieDetails: getMovieDetails,
            deleteMovie: deleteMovie,
            getActorsGenresDirectors: getActorsGenresDirectors,
            addMovie: addMovie,
            getActorsGenresDirectorsMovie: getActorsGenresDirectorsMovie,
            editExistingMovie: editExistingMovie,
            searchForMovies: searchForMovies
        }
    });