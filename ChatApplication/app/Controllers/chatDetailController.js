myApp.controller('chatDetailController', ['$scope', 'chatDetailData', 'chatDetaillDatas', '$location', function ($scope, chatDetailData, chatDetaillDatas, $location) {
    $scope.con = "ChatGroup Details";

    $scope.editchatgroup = function (Id) {
        $location.path('/chatGroupDetail/' + Id);
    };

    $scope.deletechatgroup = function (Id) { 
        chatDetaillDatas.delete({ id: Id }).$promise.then(function (resource) {
            console.log('success', resource);
            $scope.getgroupname = chatDetailData.query();
        });  
    };

   
    chatDetailData.query().$promise.then(
    function (resource) {
     $scope.getgroupname = resource;
     console.log(resource);

 });
}]);



