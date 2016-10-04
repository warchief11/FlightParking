/// <reference path="flightParkModule.js" />
angular.module('flightParking', [])
    .controller('GatesDashboardCtrl', ['$scope', 'Parking', function ($scope, Parking) {
        var reservations;
        $scope.reservations = [{}];
        $scope.gateId = 1;
        Parking.getGates().then(function (gates) {
            $scope.gates = gates;
        });
        Parking.getReservations($scope.gateId).then(function (reservations) {
            $scope.reservations = reservations;
        });
    }]);