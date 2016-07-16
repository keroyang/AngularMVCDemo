var AngularMVCApp = angular.module('AngularMVCApp', ['ngRoute']);

AngularMVCApp.controller('LandingPageController', LandingPageController);

var configFunction = function ($routeProvider) {
    $routeProvider.
        when('/User/ListPage', {
            templateUrl: 'User/ListPage'
        })
        .when('/User/EditPage/:id', {
            templateUrl: function(params) { return 'User/EditPage/' + params.id; }
    }).when('/User/Delete', {
            templateUrl: '/User/Delete'
    });
      
}
configFunction.$inject = ['$routeProvider'];

AngularMVCApp.config(configFunction);
