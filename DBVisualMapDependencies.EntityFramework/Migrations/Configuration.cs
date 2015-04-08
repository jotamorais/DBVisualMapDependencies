namespace DBVisualMapDependencies.Migrations
{
	using DBVisualMapDependencies.EntityFramework;
	using System.Data.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<DBVisualMapDependenciesDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
			//ContextKey = "DBVisualMapDependencies";
		}

		protected override void Seed(DBVisualMapDependenciesDbContext context)
		{
			// This method will be called every time after migrating to the latest version.
			// You can add any seed data here...
		}
	}
}
