using Abp.Domain.Repositories;
using System.Collections.Generic;

namespace DBVisualMapDependencies
{
	/// <summary>
	/// Defines a repository to perform database operations for <see cref="DBObject"/> Entities.
	/// 
	/// Extends <see cref="IRepository{TEntity, TPrimaryKey}"/> to inherit base repository functionality. 
	/// </summary>
	public interface IDBObjectRepository : IRepository<DBObject, int>
	{
		/// <summary>
		/// Gets all DB Objects with <see cref="DBObject"/> is retrived (Include for EntityFramework, Fetch for NHibernate)
		/// filtered by given conditions.
		/// </summary>
		/// <param name="dbObjectId">Optional DB object Id filter. If it's null, not filtered.</param>
		/// <returns>List of found tasks</returns>
		List<DBObject> GetAllWithChildrens(int? dbObjectId);
	}
}
