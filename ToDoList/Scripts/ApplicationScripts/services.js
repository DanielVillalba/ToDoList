// service used to interact with WEB API 2

app.service('APIService', function ($http) {
    this.getTasks = function () {
        return $http.get("/TDLists/getAllTasks")
    }

    this.addTask = function (task) {
        var response = $http({
            method: "post",
            url: "TDLists/addTask",
            data: JSON.stringify(task),
            dataType: "json"
        });
        return response;
    }


    this.deleteTask = function (taskData) {
        var response = $http({
            url: "/TDLists/deleteTask/" + taskData,
            dataType: 'json',
            method: 'GET'
        });
        return response;
    }

});

// service used to share a product object among diff controllers, basically to update or delete ops

app.service('ShareService', function ($http) {
    var task;

    var storeTaskToShare = function (newObj) {
        task = newObj;
    }

    var getStoredTaskFromShare = function () {
        return task;
    }

    return {
        storeTaskToShare: storeTaskToShare,
        getStoredTaskFromShare: getStoredTaskFromShare
    };
});