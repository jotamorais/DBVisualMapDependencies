using Abp.Localization;
using Abp.Localization.Sources.Xml;
using Abp.Modules;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DBVisualMapDependencies.Web
{
	[DependsOn(typeof(DBVisualMapDependenciesDataModule), typeof(DBVisualMapDependenciesApplicationModule), typeof(DBVisualMapDependenciesWebApiModule))]
	public class DBVisualMapDependenciesWebModule : AbpModule
	{
		public override void PreInitialize()
		{
			//Add/remove languages for your application
			Configuration.Localization.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flag-england", true));
			Configuration.Localization.Languages.Add(new LanguageInfo("br", "Português", "famfamfam-flag-br"));

			//Add/remove localization sources here
			Configuration.Localization.Sources.Add(
				new XmlLocalizationSource(
					DBVisualMapDependenciesConsts.LocalizationSourceName,
					HttpContext.Current.Server.MapPath("~/Localization/DBVisualMapDependencies")
					)
				);

			//Configure navigation/menu
			Configuration.Navigation.Providers.Add<DBVisualMapDependenciesNavigationProvider>();
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

			AreaRegistration.RegisterAllAreas();
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
