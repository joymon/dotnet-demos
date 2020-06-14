app.service("RESTClientService",["$http", function ($http) {
    var apiPrefix = "../api/Files/"
    this.get = function (radius, operation_id) {
        var url = apiPrefix + radius;
        var guid = operation_id;
        //The RequestId header passed from here is taken as operation id at webhttp WCF side to correlate.
        return $http.get(url, {
            headers: {
                'Request-Id': guid,
                'x-ms-request-id': guid,
                'x-ms-request-root-id': operation_id
            }
        }
        );
    };
    this.getWithCacheControlMode = function (radius, mode) {
        var url = apiPrefix + radius + "/mode/" + mode;
        return $http.get(url, {});
    }
    this.getWithCacheControl = function (radius) {
        var url = apiPrefix;
        return $http.get(url, {});
    }
    this.getWithExpires = function (radius) {
        var url = apiPrefix + radius + "/mode/2";
        //The RequestId header passed from here is taken as operation id at webhttp WCF side to correlate.
        return $http.get(url, {});
    };
    this.getAreaWithETag = function (radius) {
        var url = apiPrefix + radius + "/mode/4";
        //The RequestId header passed from here is taken as operation id at webhttp WCF side to correlate.
        return $http.get(url, {});
    }
}]);
