using System.Data.Entity.ModelConfiguration;

namespace DBVisualMapDependencies.Mapping
{
	public class DBObjectMap : EntityTypeConfiguration<DBObject>
	{
		public DBObjectMap()
		{

			// Table & Column Mappings
			this.ToTable("vDBObjectDependencyMapping", "dbo");
			this.Property(t => t.Id).HasColumnName("Id");
			this.Property(t => t.Schema).HasColumnName("Schema");
			this.Property(t => t.Name).HasColumnName("Name");
			this.Property(t => t.Type).HasColumnName("Type");
			this.Property(t => t.ChildId).HasColumnName("ChildId");
			this.Property(t => t.ChildSchema).HasColumnName("ChildSchema");
			this.Property(t => t.ChildName).HasColumnName("ChildName");
			this.Property(t => t.ChildType).HasColumnName("ChildType");
		}
	}
}
