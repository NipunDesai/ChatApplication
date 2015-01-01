
myApp.controller('createNewGroupController', ['$scope', '$routeParams', '$rootScope', 'createNewGroupData', 'chatDetailData', 'chatDetaillDatas', 'chatGroupUpdateData', 'chatGroupDetailData', function ($scope, $routeParams, $rootScope, createNewGroupData, chatDetailData, chatDetaillDatas, chatGroupUpdateData, chatGroupDetailData) {
      
    //Create method// and //Update Method//

    $scope.CreateNew = function (newgame) {
        if ($scope.newgame.Id == null) {
            $scope.newgame = {};  
            createNewGroupData.save(newgame).$promise.then(function (resource) {
                console.log('success', resource);
                $scope.updatedata();
                //$scope.getgroupname = chatDetailData.query();    
            });
        }
        else {
            $scope.newgame = {};
            chatGroupUpdateData.update(newgame).$promise.then(function (resource) {
                console.log('',resource);
                $scope.updatedata();
            });
         }
    };

    //Get Method//
   $scope.getgroupname = chatDetailData.query();
   
    $scope.updatedata = function () {
        chatDetailData.query().$promise.then(function (resource) {
            $scope.getgroupname = resource;});
    };

    //Edit Method//
    $scope.editchatgroup = function (Id) {
    for (i in $scope.getgroupname) {
        if ($scope.getgroupname[i].Id == Id) {
            $scope.newgame = angular.copy($scope.getgroupname[i]);
        }
    }
};

    //DeleteMethode//
    $scope.deletechatgroup = function (Id) {
        chatDetaillDatas.delete({ id: Id }).$promise.then(function (resource) {
            console.log('success', resource);
            $scope.updatedata();
        });
    };

}]);



