/// <reference path="flightParkModule.js" />
angular.module('parkApp')
    .controller('GatesDashboardCtrl', ['$scope', 'Parking', function ($scope, Parking) {
        $scope.gateId = 4;
        Parking.getGates().then(function (gates) {
            $scope.gates = gates;
        });
        Parking.getReservations($scope.gateId).then(function (reservations) {
            $scope.reservations = reservations;
        });
    }]);