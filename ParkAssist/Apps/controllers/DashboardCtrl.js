/// <reference path="flightParkModule.js" />
angular.module('parkApp')
    .controller('DashboardCtrl', ['$scope', 'Parking', function ($scope, Parking) {
        Parking.getGates().then(function (gates) {
            $scope.gates = gates;
            $scope.selectedGate = 3;
        });
        Parking.getReservations($scope.gateId).then(function (reservations) {
            $scope.reservations = reservations;
        });
    }]);