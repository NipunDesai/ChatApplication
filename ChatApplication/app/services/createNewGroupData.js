
myApp.factory('createNewGroupData', ['$resource', function ($resource) {

    var resource = $resource('api/Chat/Create', null);
    resource.save();
    return resource;
}]);

myApp.factory('chatDetailData', ['$resource', function ($resource) {
    var resource = $resource('api/Chat/GetAllChatGroup', {}, { 'query': { method: 'GET', isArray: true } });
    resource.query();
    return resource;
}]);

myApp.factory('chatDetaillDatas', ['$resource', function ($resource) {
    var resource = $resource('api/Chat/Delete/:id');
    resource.delete();
    return resource;
}]);

myApp.factory('chatGroupUpdateData', ['$resource', function ($resource) {
    var resource = $resource('api/Chat/Put/:id',null, { 'update': { method: 'PUT' } });
    resource.update();
    return resource;
}]);

