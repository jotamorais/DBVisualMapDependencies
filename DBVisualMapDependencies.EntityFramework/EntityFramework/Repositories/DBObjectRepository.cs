using Abp.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace DBVisualMapDependencies.EntityFramework.Repositories
{
	public class DBObjectRepository : DBVisualMapDependenciesRepositoryBase<DBObject, int>, IDBObjectRepository
	{
		public DBObjectRepository(IDbContextProvider<DBVisualMapDependenciesDbContext> dbContextProvider)
			: base(dbContextProvider)
		{
		}

		public List<DBObject> GetAllWithChildrens(int? dbObjectId)
		{
			//In repository methods, we do not deal with create/dispose DB connections, DbContexes and transactions. ABP handles it.

			var query = GetAll(); //GetAll() returns IQueryable<T>, so we can query over it.
			//var query = Context.Tasks.AsQueryable(); //Alternatively, we can directly use EF's DbContext object.
			//var query = Table.AsQueryable(); //Another alternative: We can directly use 'Table' property instead of 'Context.Tasks', they are identical.

			//Add some Where conditions...

			if (dbObjectId.HasValue)
			{
				query = query.Where(dbObject => dbObject.Id == dbObjectId.Value);
			}

			return query
				.OrderByDescending(dbObject => dbObject.Name)
				.ThenBy(dbObject => dbObject.Schema)
				.ToList();
		}
	}
}
