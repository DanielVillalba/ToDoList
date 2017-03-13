var mainApp = angular.module('TodoList');

mainApp.controller('DeleteController', function ($scope, APIService, ShareService) {
    $scope.areUSure = 'Are you sure you want to delete this product?';

    var task = ShareService.getStoredTaskFromShare();
    $scope.task = task;

    $scope.delete = function () {
        var serviceCall = APIService.deleteTask(task.ListId);
    }
});