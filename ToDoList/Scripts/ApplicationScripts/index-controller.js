var mainApp = angular.module('TodoList');

mainApp.controller('IndexController', function ($scope, APIService, ShareService) {
    $scope.greeting = 'Hola!';
    getTasks();

    function getTasks() {
        console.log('requesting data');
        var serviceCall = APIService.getTasks();
        serviceCall.then(function (data) {
            $scope.tasks = angular.fromJson(data.data);
        }, function (error) {
            console.log('something went wrong !');
        })
    }


    $scope.edit = function (listId, name, description, isDone) {
        var taskToEdit =
        {
            ListId: listId,
            Name: name,
            Description: description,
            IsDone: isDone,
        }
        ShareService.storeTaskToShare(taskToEdit);
    }
    $scope.delete = function (listId, name, description, isDone) {

        var taskToDelete =
        {
            ListId: listId,
            Name: name,
            Description: description,
            IsDone: isDone,
        }
        ShareService.storeTaskToShare(taskToDelete);
    }

});

