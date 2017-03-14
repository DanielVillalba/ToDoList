var mainApp = angular.module('TodoList');

mainApp.controller('NewController', function ($scope, $location, APIService) {
    $scope.newTask = 'Enter new task data!';

    $scope.ListId;
    $scope.Name;
    $scope.Description;

    $scope.saveTask = function () {
        var newTask = new Object();
        newTask.ListId = $scope.ListId;
        newTask.Name = $scope.Name;
        newTask.Description = $scope.Description;
        newTask.IsDone = false;
        var serviceCall = APIService.addTask(newTask);
        serviceCall.then(function (data) {
            console.log('navigating to index after add task...');
            return $location.path('/');
        }, function (error) {
            console.log('something went wrong !');
        });
    }
});
