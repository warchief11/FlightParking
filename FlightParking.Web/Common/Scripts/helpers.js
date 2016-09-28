var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('FlightParking');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);