var mainApp = angular.module('TodoList');

mainApp.controller('UpdateController', function ($scope, $location, APIService, ShareService) {
    $scope.update = 'Please change the values you want to update !';

    var task = ShareService.getStoredTaskFromShare();
    $scope.task = task;


    $scope.updateProduct = function () {
        var serviceCall = APIService.updateTask($scope.task);
        serviceCall.then(function (data) {
            console.log('navigating to index after update task...');
            return $location.path('/');
        }, function (error) {
            console.log('something went wrong !');
        });
    }

});