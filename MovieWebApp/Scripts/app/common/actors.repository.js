angular.module('app').service('actorsRepository',
    function ($http) {

        function getActorDetails(id) {
            return $http.get('/actors',
                {
                    params: {
                        id: id
                    }
                });
            }

        return {
            getActorDetails: getActorDetails
        }
    });