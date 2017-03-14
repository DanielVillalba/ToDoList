var mainApp = angular.module('TodoList');

mainApp.controller('DeleteController', function ($scope, $location, APIService, ShareService) {
    $scope.areUSure = 'Are you sure you want to delete this product?';

    var task = ShareService.getStoredTaskFromShare();
    $scope.task = task;

    $scope.delete = function () {
        var serviceCall = APIService.deleteTask(task.ListId);
        serviceCall.then(function (data) {
            console.log('navigating to index after delete task...');
            return $location.path('/');
        }, function (error) {
            console.log('something went wrong !');
        });
    }
});