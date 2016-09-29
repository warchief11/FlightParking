angular.module('ParkingModule').service('bookings', ['$http', function ($http) {
   'use strict';

   var getReservations = function (gateId) {
       return $http({
           method: "GET",
           url: "\\Reservations\\",
           cache: false,
           params: { 'gateId': gateId }
       });
   };

   return {
       getReservations: getReservations()
   };
}])