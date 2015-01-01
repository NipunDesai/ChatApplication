myApp.factory('chatGroupDetailData',['$resource' ,function ($resource) {
    var resource = $resource('api/Chat/Get/:id', {id:'@id'}, { 'get': { method: 'GET' } });
    resource.get();
    return resource;
}]);

myApp.factory('chatGroupUpdateData', ['$resource', function ($resource) {
    var resource = $resource('api/Chat/Put/:id', { id: '@id' }, { 'update': { method: 'PUT' } });
    resource.update();
    return resource;
}]);