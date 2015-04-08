using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Events.Bus.Exceptions;
using Abp.Web;
using Castle.Core.Logging;
using Castle.Facilities.Logging;
using System;

namespace DBVisualMapDependencies.Web
{
	public class MvcApplication : AbpWebApplication
	{
		public static ILogger Logger { get; set; }

		protected override void Application_Start(object sender, EventArgs e)
		{
			IocManager.Instance.IocContainer.AddFacility<LoggingFacility>(f => f.UseLog4Net().WithConfig("log4net.config"));

			base.Application_Start(sender, e);

			EventBus.Default.Register<AbpHandledExceptionData>(
			data =>
			{
				//use data.Exception to see exception details
				Logger.Error("EVENT_BUS" + data.Exception);
			});
		}

	}
}
