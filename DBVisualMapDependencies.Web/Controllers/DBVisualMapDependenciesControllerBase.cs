using Abp.Web.Mvc.Controllers;

namespace DBVisualMapDependencies.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class DBVisualMapDependenciesControllerBase : AbpController
    {
        protected DBVisualMapDependenciesControllerBase()
        {
            LocalizationSourceName = DBVisualMapDependenciesConsts.LocalizationSourceName;
        }
    }
}