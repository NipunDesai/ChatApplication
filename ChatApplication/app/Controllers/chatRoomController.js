myApp.controller('chatRoomController', ['$scope', 'chatRoomData', 'chatService', function ($scope, chatRoomData, chatService) {

    $scope.getUser = chatRoomData.query;
    $scope.text = "Wel-Come To ChatRoom";

    chatService.connect();
    $scope.messages = [];
    $scope.data = "error";
  //  $scope.name = "nipun";
  

    $scope.$on('addNewMessageToPage', function (event, message) {
        $scope.messages.push(message);
        $scope.$apply();
    });

    $scope.send = function (message) {
        chatService.send(message);
        $scope.message = '';
    };

    chatRoomData.query().$promise.then(
        function (resource) {
            $scope.cons = resource;
            console.log(resource);
        });

}]);