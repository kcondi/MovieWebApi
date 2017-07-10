angular.module('app').service('directorsRepository',
    function ($http) {

        function getAllDirectors() {
            return $http.get('/movies/add');
        }

        return {
            getAllDirectors: getAllDirectors
        }
    });