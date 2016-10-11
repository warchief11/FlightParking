/// <reference path="flightParkModule.js" />
angular.module('parkApp')
    .controller('DashboardCtrl', ['$scope', 'Parking', function ($scope, Parking) {
        $scope.selectedGate = 4;
        Parking.getGates().then(function (gates) {
            $scope.gates = gates;
        });
        Parking.getReservations($scope.gateId).then(function (reservations) {
            $scope.reservations = reservations;
        });
    }]);