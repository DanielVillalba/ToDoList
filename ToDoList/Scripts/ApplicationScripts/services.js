// service used to interact with WEB API 2

app.service('APIService', function ($http) {
    this.getTasks = function () {
        return $http.get("/TDLists/getAllTasks")
    }

    this.newProduct = function (newData) {
        $http({
            url: "../api/ProductsAPI",
            dataType: 'json',
            method: 'POST',
            data: newData,
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

    this.deleteProduct = function (newData) {
        $http.delete("../api/ProductsAPI/" + newData)
    }

    this.updateProduct = function (newData) {
        $http({
            url: "../api/ProductsAPI/" + newData.Id,
            dataType: 'json',
            method: 'PUT',
            data: newData,
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
});

// service used to share a product object among diff controllers, basically to update or delete ops

app.service('ShareService', function ($http) {
    var product;

    var storeProductToShare = function (newObj) {
        product = newObj;
        //console.log('from share service object.. ' + product.Id);
        //console.log('from share service object.. ' + product.Name);
        //console.log('from share service object.. ' + product.Description);
        //console.log('from share service object.. ' + product.AgeRestriction);
        //console.log('from share service object.. ' + product.Company);
        //console.log('from share service object.. ' + product.Price);
    }

    var getStoredProductFromShare = function () {
        return product;
    }

    return {
        storeProductToShare: storeProductToShare,
        getStoredProductFromShare: getStoredProductFromShare
    };
});