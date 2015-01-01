myApp.factory('chatRoomData', function ($resource) { 
    var resource = $resource('api/User/Get', null);
    resource.query();
    return resource;
});

myApp.factory('chatService',['$','$rootScope', function ($,$rootScope) {
    var proxy;
    var connection;
    return {
        connect: function () {
            connection = $.hubConnection();
            proxy = connection.createHubProxy('chatHub');
            connection.start();
            proxy.on('addNewMessageToPage', function (message) {
                $rootScope.$broadcast('addNewMessageToPage', message);
            });
        },
        isConnecting: function () {
            return connection.state === 0;
        },
        isConnected: function () {
            return connection.state === 1;
        },
        connectionState: function () {
            return connection.state;
        },
        send: function (message) {
            proxy.invoke('send', message);
        },
    }
}]);

