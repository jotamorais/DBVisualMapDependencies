using Abp.EntityFramework;
using DBVisualMapDependencies.Mapping;
using System.Data.Common;
using System.Data.Entity;

namespace DBVisualMapDependencies.EntityFramework
{
	public class DBVisualMapDependenciesDbContext : AbpDbContext
	{
		public virtual IDbSet<DBObject> DBObjects { get; set; }

		/* NOTE: 
		 *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
		 *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
		 *   pass connection string name to base classes. ABP works either way.
		 */
		public DBVisualMapDependenciesDbContext()
			: base("Default")
		{

		}

		/* NOTE:
		 *   This constructor is used by ABP to pass connection string defined in DBVisualMapDependenciesDataModule.PreInitialize.
		 *   Notice that, actually you will not directly create an instance of DBVisualMapDependenciesDbContext since ABP automatically handles it.
		 */
		public DBVisualMapDependenciesDbContext(string nameOrConnectionString)
			: base(nameOrConnectionString)
		{

		}

		//This constructor is used in tests
		public DBVisualMapDependenciesDbContext(DbConnection connection)
			: base(connection, true)
		{

		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new DBObjectMap());
		}
	}
}
