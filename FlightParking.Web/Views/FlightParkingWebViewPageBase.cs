using Abp.Web.Mvc.Views;

namespace FlightParking.Web.Views
{
    public abstract class FlightParkingWebViewPageBase : FlightParkingWebViewPageBase<dynamic>
    {

    }

    public abstract class FlightParkingWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected FlightParkingWebViewPageBase()
        {
            LocalizationSourceName = FlightParkingConsts.LocalizationSourceName;
        }
    }
}