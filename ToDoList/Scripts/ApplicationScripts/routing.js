var mainApp = angular.module('TodoList');

mainApp.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Templates/allTasks.html",
        controller: "IndexController"
    })
    .when("/newTask", {
        templateUrl: "/Templates/newTask.html",
        controller: "NewController"
    })
    .when("/updateTask", {
        templateUrl: "/Templates/updateTask.html"
    })
    .when("/deleteTask", {
        templateUrl: "/Templates/deleteTask.html",
        controller: "DeleteController"
    });


});


