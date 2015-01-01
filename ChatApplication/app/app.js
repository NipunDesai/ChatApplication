var myApp = angular.module('myApp', ['ngRoute', 'ngAnimate', 'ngResource']);
myApp.value('$', $);
myApp.config(function ($routeProvider) {
    $routeProvider.when('/home', {
        templateUrl: "app/Demo/home.html",
        controller: "mainController"
    }).when('/chatRoom', {
        templateUrl: "app/Demo/chatRoom.html",
        controller: "chatRoomController"
    }).when('/createNewGroup', {
        templateUrl: "app/Demo/createNewGroup.html",
        controller: "createNewGroupController"
    }).when('/LoginPage', {
        templateUrl: "app/Demo/LoginPage.html",
        controller: "loginController"
    }).when('/createNewAccount', {
        templateUrl: "app/Demo/createNewAccount.html",
        controller: "accountController"
    }).when('/chatDetails', {
        templateUrl: "app/Demo/chatDetails.html",
        controller: "chatDetailController"
    }).when('/chatGroupDetail/:id', {
        templateUrl: "app/Demo/chatGroupDetail.html",
        controller: "chatGroupDetailController"
    }).when('/chat', {
        templateUrl: "app/Demo/chat.html",
        controller: "chatController"
    });
});