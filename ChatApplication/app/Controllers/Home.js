// Usercontroller($scope) {   
myApp.controller('Usercontroller', [
    '$scope', 'eventData', function ($scope, eventData) {
       
    $scope.email = /^[a-z0-9!#$%&'*+/=?^_`{|}~.-]+@[a-z0-9-]+(\.[a-z0-9-]+)*$/i;
    $scope.uname = /^[a-zA-Z]{4,15}$/;

    $scope.contacts = eventData.con;
    //$scope.contacts = [{
    //    'name':'nipun',
    //    'email':'nipun@gmail.com',
    //    'phone':'1238-2343-44'
    //}]
    $scope.saveContact = function () {
        $scope.contacts.push($scope.newcontact);
        $scope.newcontact = {};
    }
    $scope.orderProp = 'name';
    }]);
