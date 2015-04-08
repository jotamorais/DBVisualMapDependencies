using Abp.Web.Mvc.Views;

namespace DBVisualMapDependencies.Web.Views
{
    public abstract class DBVisualMapDependenciesWebViewPageBase : DBVisualMapDependenciesWebViewPageBase<dynamic>
    {

    }

    public abstract class DBVisualMapDependenciesWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DBVisualMapDependenciesWebViewPageBase()
        {
            LocalizationSourceName = DBVisualMapDependenciesConsts.LocalizationSourceName;
        }
    }
}