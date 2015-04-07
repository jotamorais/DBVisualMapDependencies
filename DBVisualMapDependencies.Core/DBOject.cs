using Abp.Domain.Entities;

namespace DBVisualMapDependencies
{
	/// <summary>
	/// Represent a DB object (i.e: from MSSSQL: sys.object)
	/// </summary>
	public class DBObject : Entity<int>
	{
		///// <summary>
		///// The unique identifier of a DB object
		///// </summary>
		public virtual int Id { get; set; }

		///// <summary>
		///// The schema where the DB object lives in
		///// </summary>
		public virtual string Schema { get; set; }

		///// <summary>
		///// The DB object name
		///// </summary>
		public virtual string Name { get; set; }

		///// <summary>
		///// The DB object type
		///// </summary>
		public virtual string Type { get; set; }

		///// <summary>
		///// The unique identifier of dependant DB object
		///// </summary>
		public virtual int ChildId { get; set; }

		///// <summary>
		///// The schema where the dependant DB object lives in
		///// </summary>
		public virtual string ChildSchema { get; set; }

		///// <summary>
		///// The dependant DB object name
		///// </summary>
		public virtual string ChildName { get; set; }

		///// <summary>
		///// The dependant DB object type
		///// </summary>
		public virtual string ChildType { get; set; }



	}
}
