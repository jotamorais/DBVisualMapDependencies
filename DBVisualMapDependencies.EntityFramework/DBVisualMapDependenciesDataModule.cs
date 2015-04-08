using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using DBVisualMapDependencies.EntityFramework;

namespace DBVisualMapDependencies
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(DBVisualMapDependenciesCoreModule))]
    public class DBVisualMapDependenciesDataModule : AbpModule
    {
        public override void PreInitialize()
        {
			Configuration.DefaultNameOrConnectionString = "DBVisualMapDependencies";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<DBVisualMapDependenciesDbContext>(null);
        }
    }
}
