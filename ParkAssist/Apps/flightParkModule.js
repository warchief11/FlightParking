(function () {
    'use Strict';

    var flightParkModule = angular.module('flightParking', ['ui.router']);

    flightParkModule.config( [ '$stateProvider', '$urlRouterProvider',function ($stateProvider,   $urlRouterProvider) {
        $urlRouterProvider.otherwise('/home');
        $stateProvider
             .state("home", {

                 // Use a url of "/" to set a state as the "index".
                 url: "/",

                 // Example of an inline template string. By default, templates
                 // will populate the ui-view within the parent state's template.
                 // For top level states, like this one, the parent template is
                 // the index.html file. So this template will be inserted into the
                 // ui-view within index.html.
                 template: '<p class="lead">Welcome to the UI-Router Demo</p>' +
                   '<p>Use the menu above to navigate. ' +
                   'Pay attention to the <code>$state</code> and <code>$stateParams</code> values below.</p>' +
                   '<p>Click these links—<a href="#/c?id=1">Alice</a> or ' +
                   '<a href="#/user/42">Bob</a>—to see a url redirect in action.</p>'

             })
            .state('about', {
                url: '/about',
                templateUrl: 'templates/about.html',
                controller: ['$scope', 'Parking', function ($scope, Parking) {
                    var reservations;
                    $scope.reservations = [{ Id: 1, gateId: 1, flightId: 1 }, { Id: 2, gateId: 1, flightId: 2 }];
                    $scope.gateId = 1;
                    Parking.getGates().then(function (gates) {
                        $scope.gates = gates;
                    });
                    Parking.getReservations($scope.gateId).then(function (reservations) {
                        $scope.reservations = reservations;
                    });
                }]
            });
    }]);
   
    flightParkModule.run(function ($rootScope) {
        var $rootScope = angular.element(document.querySelectorAll("[ui-view]")[0]).injector().get('$rootScope');

        $rootScope.$on('$stateChangeStart', function (event, toState, toParams, fromState, fromParams) {
            console.log('$stateChangeStart to ' + toState.to + '- fired when the transition begins. toState,toParams : \n', toState, toParams);
        });

        $rootScope.$on('$stateChangeError', function (event, toState, toParams, fromState, fromParams) {
            console.log('$stateChangeError - fired when an error occurs during transition.');
            console.log(arguments);
        });

        $rootScope.$on('$stateChangeSuccess', function (event, toState, toParams, fromState, fromParams) {
            console.log('$stateChangeSuccess to ' + toState.name + '- fired once the state transition is complete.');
        });

        $rootScope.$on('$viewContentLoaded', function (event) {
            console.log('$viewContentLoaded - fired after dom rendered', event);
        });

        $rootScope.$on('$stateNotFound', function (event, unfoundState, fromState, fromParams) {
            console.log('$stateNotFound ' + unfoundState.to + '  - fired when a state cannot be found by its name.');
            console.log(unfoundState, fromState, fromParams);
        });
    });
}());