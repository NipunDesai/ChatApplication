myApp.controller('mainController', ['$scope', 'mainData', function ($scope, mainData) {
    $scope.cons = mainData.con.title;
}]);