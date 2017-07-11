angular.module('app').service('movieListsRepository',
    function ($http) {

        function getAllMovieLists() {
            return $http.get('/movielists');
        }

        function getMovieListDetails(id) {
            return $http.get('/movielists/details',
                {
                    params: {
                        id: id
                    }
                });
        }

        function deleteMovieList(id) {
            return $http.delete('/movielists/delete',
                {
                    params: {
                        id: id
                    }
                });
        }

        function getAllMovies() {
            return $http.get('/movielists/add');
        }

        function addMovieList(newMovie) {
            return $http.post('/movielists/add', newMovie);
        }

        function getMoviesMovieList(id) {
            return $http.get('movielists/edit',
                {
                    params: {
                        id: id
                    }
                });
        }

        function editExistingMovieList(editedMovieList) {
            return $http.post('/movielists/edit', editedMovieList);
        }

        return {
            getAllMovieLists: getAllMovieLists,
            getMovieListDetails: getMovieListDetails,
            deleteMovieList: deleteMovieList,
            getAllMovies: getAllMovies,
            addMovieList: addMovieList,
            getMoviesMovieList: getMoviesMovieList,
            editExistingMovieList: editExistingMovieList
        }
    });