// service used to interact with WEB API 2

app.service('APIService', function ($http) {
    this.getTasks = function () {
        return $http.get("/TDLists/getAllTasks")
    }

    //this.newProduct = function (newData) {
    //    $http({
    //        url: "../api/ProductsAPI",
    //        dataType: 'json',
    //        method: 'POST',
    //        data: newData,
    //        headers: {
    //            "Content-Type": "application/json"
    //        }
    //    })
    //    .then(function (data) {
    //        console.log(data);
    //    }, function (error) {
    //        console.log('something went wrong !');
    //    })
    //}


    this.deleteTask = function (taskData) {
        console.log('----------------> ' + taskData);
        $http({
            url: "/TDLists/deleteTask/" + taskData,
            dataType: 'json',
            method: 'GET',
            //id: taskData,
            headers: {
                "Content-Type": "application/json"
            }
        })
        .then(function (data) {
            console.log(data);
        }, function (error) {
            console.log('something went wrong !');
        })
    }

    //this.deleteTask = function (deleteData) {
    //    $http.post("/TDLists/deleteTask/" + deleteData)
    //}

    //this.updateProduct = function (newData) {
    //    $http({
    //        url: "../api/ProductsAPI/" + newData.Id,
    //        dataType: 'json',
    //        method: 'PUT',
    //        data: newData,
    //        headers: {
    //            "Content-Type": "application/json"
    //        }
    //    })
    //    .then(function (data) {
    //        console.log(data);
    //    }, function (error) {
    //        console.log('something went wrong !');
    //    })
    //}
});

// service used to share a product object among diff controllers, basically to update or delete ops

app.service('ShareService', function ($http) {
    var task;

    var storeTaskToShare = function (newObj) {
        task = newObj;
        //console.log('from share service object.. ' + task.ListId);
        //console.log('from share service object.. ' + task.Name);
        //console.log('from share service object.. ' + task.Description);
        //console.log('from share service object.. ' + task.IsDone);
    }

    var getStoredTaskFromShare = function () {
        return task;
    }

    return {
        storeTaskToShare: storeTaskToShare,
        getStoredTaskFromShare: getStoredTaskFromShare
    };
});