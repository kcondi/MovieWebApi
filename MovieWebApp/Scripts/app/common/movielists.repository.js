angular.module('app').service('movieListsRepository',
    function ($http) {

        function getAllMovieLists() {
            return $http.get('/api/movielists');
        }

        function getMovieListDetails(id) {
            return $http.get('/api/movielists/details',
                {
                    params: {
                        id: id
                    }
                });
        }

        function deleteMovieList(id) {
            return $http.delete('/api/movielists/delete',
                {
                    params: {
                        id: id
                    }
                });
        }

        function getAllMovies() {
            return $http.get('/api/movielists/add');
        }

        function addMovieList(newMovie) {
            return $http.post('/api/movielists/add', newMovie);
        }

        function getMoviesMovieList(id) {
            return $http.get('/api/movielists/edit',
                {
                    params: {
                        id: id
                    }
                });
        }

        function editExistingMovieList(editedMovieList) {
            return $http.post('/api/movielists/edit', editedMovieList);
        }

        function addRandomList(numberOfMovies, genre) {
            var indata = {'numberOfMovies':numberOfMovies,'genre':genre}
            return $http.post('/api/movielists/addrandom', indata);
        }

        return {
            getAllMovieLists: getAllMovieLists,
            getMovieListDetails: getMovieListDetails,
            deleteMovieList: deleteMovieList,
            getAllMovies: getAllMovies,
            addMovieList: addMovieList,
            getMoviesMovieList: getMoviesMovieList,
            editExistingMovieList: editExistingMovieList,
            addRandomList: addRandomList
        }
    });