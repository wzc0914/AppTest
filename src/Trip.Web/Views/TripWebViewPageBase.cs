using Abp.Web.Mvc.Views;

namespace Trip.Web.Views
{
    public abstract class TripWebViewPageBase : TripWebViewPageBase<dynamic>
    {

    }

    public abstract class TripWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TripWebViewPageBase()
        {
            LocalizationSourceName = TripConsts.LocalizationSourceName;
        }
    }
}