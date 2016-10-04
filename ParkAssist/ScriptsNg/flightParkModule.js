(function () {
    'use Strict';

    var flightParkModule = angular.module('flightPark', ['ngRoute', 'ngAnimate']);

    flightParkModule.config('$routeProvider', function ($routeProvider) {
        $routeProvider
            .when('/dashboard', {
                controller: 'dashboard',
                templateUrl: 'ScriptsNg/pages/dashboard.html'
            })
            .when('/flightAdd', {
                controller: 'flightAdd',
                templateUrl: 'ScriptsNg/pages/flightAdd.html'
            });
    });

})();