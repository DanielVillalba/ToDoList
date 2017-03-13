var mainApp = angular.module('TodoList');

mainApp.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Templates/allTasks.html",
        controller: "IndexController"
    })
    //.when("/newTest", {
    //    templateUrl: "/Templates/AddNewProduct.html",
    //    controller: "NewController"
    //})
    //.when("/updateProduct", {
    //    templateUrl: "/Templates/UpdateProduct.html"
    //})
    .when("/deleteTask", {
        templateUrl: "/Templates/deleteTask.html",
        controller: "DeleteController"
    });


});


