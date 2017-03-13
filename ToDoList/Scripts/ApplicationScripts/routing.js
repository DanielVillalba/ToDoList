var mainApp = angular.module('TodoList');

mainApp.config(function ($routeProvider) {
    $routeProvider
    .when("/", {
        templateUrl: "/Templates/AllTasks.html",
        controller: "IndexController"
    })
    //.when("/newTest", {
    //    templateUrl: "/Templates/AddNewProduct.html",
    //    controller: "NewController"
    //})
    //.when("/updateProduct", {
    //    templateUrl: "/Templates/UpdateProduct.html"
    //})
    //.when("/deleteProduct", {
    //    templateUrl: "/Templates/DeleteProduct.html",
    //    controller: "DeleteController"
    //});


});


