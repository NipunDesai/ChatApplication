describe('myApp',function(){
    describe('Usercontroller', function () {

        it('search', function () {
            expect(repeater('.contacts li').count());
        });

        it('order', function () {
            expect(scope.orderProp);
        });
        it('should create "phones" model with 2 phones fetched from xhr', function () {
            expect(scope.contacts).toBeUndefined();
        });
    });

});