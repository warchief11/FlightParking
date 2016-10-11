angular.module('parkApp')
            .directive('paFlightChart', function () {
                return {
                    restrict: 'E',
                    scope: {
                        reservations: '=reservations'
                    },
                    templateUrl: 'Apps/templates/paFlightChart.html'
                };

            });