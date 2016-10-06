/// <reference path="flightParkModule.js" />
angular.module('flightParking', [])
    .controller('GatesDashboardCtrl', ['$scope', 'Parking', function ($scope, Parking) {
        var reservations;
        $scope.reservations = [{ Id: 1, gateId: 1, flightId: 1 }, { Id: 2, gateId: 1, flightId: 2 }];
        $scope.gateId = 1;
        Parking.getGates().then(function (gates) {
            $scope.gates = gates;
        });
        Parking.getReservations($scope.gateId).then(function (reservations) {
            $scope.reservations = reservations;
        });
    }]);