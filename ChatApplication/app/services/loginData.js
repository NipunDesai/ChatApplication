myApp.factory('loginData', function () {
    return {
        con: {
            title:"Login Page"
        }
    };
});

//myApp.factory('loginData', function ($http) {
//    debugger;
//    this.con = function () {
//        var deferred = $q.defer();
//        $http({
//            method: 'POST',
//            Url: '/Account/Login'
//                 }).success(function (data, status, headers, config) {
//                     deferred.resolve(data);
//        }).error(function (data,status) {
//            deferred.reject(data);
//        });
//        return deferred;
//    }
 //});