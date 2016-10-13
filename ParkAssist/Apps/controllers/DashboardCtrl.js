/// <reference path="flightParkModule.js" />
angular.module('parkApp')
    .controller('DashboardCtrl', DashboardCtrl);

DashboardCtrl.$inject = ['$scope', 'Parking'];

function DashboardCtrl($scope, Parking) {
    var vm = this;

    Parking.getReservations(vm.gateId).then(function (reservations) {
        vm.reservations = reservations;
    });
    Parking.getGates().then(function (gates) {
        vm.gates = gates;
        $scope.gates = gates;
        vm.selectedGate = gates[0];
    });

   
    vm.gateSelected = function () {
        Parking.getReservations(vm.selectedGate.Id).then(function (reservations) {
            vm.reservations = reservations;
        });
    };
    return vm;
};