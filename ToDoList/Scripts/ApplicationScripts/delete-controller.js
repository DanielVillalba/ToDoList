var mainApp = angular.module('TodoList');

mainApp.controller('DeleteController', function ($scope, APIService, ShareService) {
    $scope.areUSure = 'Are you sure you want to delete this product?';

    var task = ShareService.getStoredTaskFromShare();

    console.log('xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx');

    console.log('from delete controller object.. ' + task.ListId);
    console.log('from delete controller object.. ' + task.Name);
    console.log('from delete controller object.. ' + task.Description);
    console.log('from delete controller object.. ' + task.IsDone);

    $scope.task = task;

    //--------------
    $scope.delete = function () {
        var serviceCall = APIService.deleteTask(task.ListId);
    }

});