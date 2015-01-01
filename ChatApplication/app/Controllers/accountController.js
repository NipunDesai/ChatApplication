myApp.controller('accountController', ['$scope', 'accountData', function ($scope, accountData) {
    $scope.email = /^[a-z0-9!#$%&'*+/=?^_`{|}~.-]+@[a-z0-9-]+(\.[a-z0-9-]+)*$/i;
    $scope.uname = /^[a-zA-Z]{4,15}$/;
    
    $scope.cons = accountData.con;

    $scope.Save=function() {

        $scope.cons.push($scope.newcon);
        $scope.newcon = {};
    }
}]);