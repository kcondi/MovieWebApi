angular.module('app').service('directorsRepository',
    function ($http) {

        function getDirectorDetails(id) {
            return $http.get('/directors',
                {
                    params: {
                        id: id
                    }
                });
        }

        return {
            getDirectorDetails: getDirectorDetails
        }
    });