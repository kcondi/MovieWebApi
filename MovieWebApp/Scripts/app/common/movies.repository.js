angular.module('app').service('moviesRepository',
    function($http) {

        function getAllMovies() {
            return $http.get('/api/movies');
        }

        function getMovieDetails(id) {
            return $http.get('/api/movies/details',
                {
                    params: {
                        id: id
                    }
                });
        }

        function deleteMovie(id) {
            return $http.delete('/api/movies/delete',
                {
                    params: {
                        id: id
                    }
                });
        }

        function getActorsGenresDirectors() {
            return $http.get('/api/movies/add');
        }

        function addMovie(newMovie) {
            return $http.post('/api/movies/add', newMovie);
        }

        function getActorsGenresDirectorsMovie(id) {
            return $http.get('/api/movies/edit',
                {
                    params: {
                        id: id
                    }
                });
        }

        function editExistingMovie(editedMovie) {
            return $http.post('/api/movies/edit', editedMovie);
        }

        function searchForMovies(searchtext) {
            return $http.get('/api/movies/search',
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