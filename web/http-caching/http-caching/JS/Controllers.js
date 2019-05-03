/// <reference path="../angular.min.js" />
/// <reference path="Modules.js" />
/// <reference path="Services.js" />

app.controller("RESTClientController", ['$scope', '$log', 'RESTClientService', function ($scope, $log, RESTClientService) {
    function createGuid() {
        return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function (c) {
            var r = Math.random() * 16 | 0, v = c === 'x' ? r : (r & 0x3 | 0x8);
            return v.toString(16);
        });
    }
    $scope.radius = 3;
    $scope.cachecontrol = false;
    $scope.etag = false;
    $scope.expires = false;
    $scope.testHeaders = function () {
        RESTClientService.EchoHeaders()
            .then(function (data) {
                alert(JSON.stringify(data, null, ' '));
            });
    }
    $scope.getCacheOption = function () {
        var cacheOption = 0;
        if ($scope.etag) {
            cacheOption = cacheOption | 4;
        }
        if ($scope.expires) {
            cacheOption = cacheOption | 2;
        }
        if ($scope.cachecontrol) {
            cacheOption = cacheOption | 1;
        }
        return cacheOption;
    }
    $scope.findArea = function () {
        var cacheOption = $scope.getCacheOption();
        promiseGet = RESTClientService.getWithCacheControlMode($scope.radius, cacheOption);
        promiseGet.then(
            function (pl) {
                $scope.message = pl.data;
            },
            function (errorPl) {
                $log.error('Error occured', errorPl);
                alert('Error occured', errorPl);
            }
        );
    }
    $scope.findAreaWithcachecontrol = function () {
        //alert("findAreaWithcachecontrol");
        RESTClientService.getWithCacheControl($scope.radius).then(
            function (pl) {
                $scope.message = pl.data;
            },
            function (errorPl) {
                $log.error('Error occured', errorPl);
                alert('Error occured', errorPl);
            });
    }
    $scope.findAreaWithexpires = function () {
        //alert("findAreaWithcachecontrol");
        RESTClientService.getWithExpires($scope.radius).then(
            function (pl) {
                $scope.message = pl.data;
            },
            function (errorPl) {
                $log.error('Error occured', errorPl);
                alert('Error occured', errorPl);
            });
    }
    $scope.findAreaWithETag = function () {
        //alert("findAreaWithcachecontrol");
        RESTClientService.getAreaWithETag($scope.radius).then(
            function (pl) {
                $scope.message = pl.data;
            },
            function (errorPl) {
                $log.error('Error occured', errorPl);
                alert('Error occured', errorPl);
            });
    }
}]);

