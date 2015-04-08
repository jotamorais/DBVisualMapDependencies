using Abp.Modules;
using System.Reflection;

namespace DBVisualMapDependencies
{
	[DependsOn(typeof(DBVisualMapDependenciesCoreModule))]
	public class DBVisualMapDependenciesApplicationModule : AbpModule
	{
		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

			//We must declare mappings to be able to use AutoMapper
			DtoMappings.Map();
		}
	}
}
