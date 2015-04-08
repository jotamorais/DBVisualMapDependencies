using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using System.Reflection;

namespace DBVisualMapDependencies
{
	[DependsOn(typeof(AbpWebApiModule), typeof(DBVisualMapDependenciesApplicationModule))]
	public class DBVisualMapDependenciesWebApiModule : AbpModule
	{
		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

			DynamicApiControllerBuilder
				.ForAll<IApplicationService>(typeof(DBVisualMapDependenciesApplicationModule).Assembly, "app")
				.Build();
		}
	}
}
