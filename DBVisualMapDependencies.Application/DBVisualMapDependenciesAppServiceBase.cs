using Abp.Application.Services;

namespace DBVisualMapDependencies
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class DBVisualMapDependenciesAppServiceBase : ApplicationService
    {
        protected DBVisualMapDependenciesAppServiceBase()
        {
            LocalizationSourceName = DBVisualMapDependenciesConsts.LocalizationSourceName;
        }
    }
}