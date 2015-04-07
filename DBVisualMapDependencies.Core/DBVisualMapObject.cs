using System.Collections.Generic;

namespace DBVisualMapDependencies
{
	public class DBVisualMapObject
	{
		/// <summary>
		/// The unique identifier of a DB object
		/// </summary>
		public virtual int Id { get; set; }

		/// <summary>
		/// The schema where the DB object lives in
		/// </summary>
		public virtual string Schema { get; set; }

		/// <summary>
		/// The DB object name
		/// </summary>
		public virtual string Name { get; set; }

		/// <summary>
		/// The DB object type
		/// </summary>
		public virtual string Type { get; set; }

		/// <summary>
		/// List of DB object identifiers which depends on this DB object
		/// </summary>
		public virtual ICollection<int> Childrens { get; set; }
	}
}
