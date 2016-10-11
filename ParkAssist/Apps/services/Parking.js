angular.module('parkApp').service('Parking', ['$http', '$q', function ($http, $q) {
   'use strict';

   var getReservations = function (gateId) {
       var reservations = [{ Id: 1, gateId: 1, gateName: "1A", flightId: 1, flightName: 'CA124', destination: 'Melbourne', arrival: '04:30', departure: '05:59', status: 'scheduled' },
                            { Id: 2, gateId: 4, flightId: 2, flightName: 'QA566', destination: 'Auckland', arrival: '13:30', departure: '14:29', status: 'scheduled' }]
       return $q.when(reservations);
   };

   var gates = null;
   var isGatesLoaded = false;

   var getGates = function () { 

       var gates = [{ Id: 1, Name: "1" }, { Id: 2, Name: "2" }, { Id: 3, Name: "2A" }];
       isGatesLoaded = true;
       if(isGatesLoaded){
           return $q.when(gates);
       }
       else
       {
           
           $http.getGates().then(function (response) {
               
               gates = response.Data;
               isGatesLoaded = true;
               return gates;
           });
       }
   };
   return {
       getReservations: getReservations,
       getGates: getGates
   };
}])