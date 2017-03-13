var mainApp = angular.module('TodoList');

mainApp.controller('UpdateController', function ($scope, APIService, ShareService) {
    $scope.update = 'Please change the values you want to update !';

    var task = ShareService.getStoredTaskFromShare();
    $scope.task = task;


    $scope.updateProduct = function () {
        var serviceCall = APIService.updateTask($scope.task);
    }

});