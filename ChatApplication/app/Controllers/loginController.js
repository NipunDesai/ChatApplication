//myApp.controller('loginController', ['$scope', 'loginData', '$resource', '$log', function ($scope, loginData, $resource, $log) {
//    $scope.cons = loginData.con.title;

//    //$log.info("AccountController");
   
//    //$resource('/Account/Login', function () {

//    //});
//}]);
myApp.controller('loginController', ['$scope','loginData', function ($scope, loginData) {
    $scope.cons = loginData.con.title;
    //init();
    //function init() {
    //    $scope.cons = loginData.con();
    //}
    $scope.Save = function() {
        $scope.cons.push($scope.newcon);
        $scope.newcon = {};
    }
}]);