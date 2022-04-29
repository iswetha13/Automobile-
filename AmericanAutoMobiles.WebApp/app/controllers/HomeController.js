var app = angular.module('angularTable', ['angularUtils.directives.dirPagination']);

app.controller('listdata', function ($scope, $http, $window) {

    var queryString = new Array();
    if ($window.location.search.split('?').length > 1) {
        var params = $window.location.search.split('?')[1].split('&');
        for (var i = 0; i < params.length; i++) {
            var key = params[i].split('=')[0];
            var value = decodeURIComponent(params[i].split('=')[1]);
            queryString[key] = value;
        }
    }
    var id;
    if (queryString["id"] !== null && queryString["id"]!==undefined)
        id = queryString["id"];
    else {
        alert("Invalid URL");
        return;
    }

    $scope.cars = []; //declare an empty array

    $http.get("http://localhost:9877/api/car/" + id).then(function (response) {
        if (response.status === 200)
            $scope.cars = response.data;  //ajax request to fetch data into $scope.cars
    });

    $scope.sort = function (keyname) {
        //if (keyname == "Model")
        //    $scope.sortKey = "[Model,Price]";
        //else
            $scope.sortKey = keyname;   //set the sortKey to the param passed

        $scope.reverse = !$scope.reverse; //if true make it false and vice versa
    }
});