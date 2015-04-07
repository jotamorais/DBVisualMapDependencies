using Abp.Modules;
using System;
using System.Reflection;
using System.Transactions;

namespace DBVisualMapDependencies
{
	public class DBVisualMapDependenciesCoreModule : AbpModule
	{
		public override void PreInitialize()
		{
			Configuration.UnitOfWork.IsolationLevel = IsolationLevel.ReadCommitted;
			Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);
		}

		public override void Initialize()
		{
			IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
		}
	}
}
