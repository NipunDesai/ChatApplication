myApp.factory('chatDetailData', ['$resource', function ($resource) {
    var resource = $resource('api/Chat/GetAllChatGroup', {}, { 'query': { method: 'GET', isArray: true}});
    resource.query();
    return resource;
}]);

myApp.factory('chatDetaillDatas',['$resource', function ($resource) {
    var resource = $resource('api/Chat/Delete/:id');
    resource.delete();
    return resource;
}]);

