myApp.controller('chatGroupDetailController', ['$scope', '$routeParams', 'chatGroupDetailData', 'chatGroupUpdateData', '$location', function ($scope, $routeParams, chatGroupDetailData, chatGroupUpdateData, $location) {

    $scope.a = "ChatGroup Detail";
  
    $scope.cancel = function () {
        $location.path('/chatDetails');
    };

    $scope.updatechatGroup = function () {       
        chatGroupUpdateData.update($scope.con);
        $scope.con = chatGroupDetailData.get({ id: $routeParams.id });
        $location.path('/chatDetails');  
    };

    $scope.createNewGroup = function () {
        $location.path('/createNewGroup');
    };

    $scope.con = chatGroupDetailData.get({ id: $routeParams.id });


}]);