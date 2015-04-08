using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DBVisualMapDependencies.EntityFramework.Repositories
{
    public abstract class DBVisualMapDependenciesRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DBVisualMapDependenciesDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DBVisualMapDependenciesRepositoryBase(IDbContextProvider<DBVisualMapDependenciesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DBVisualMapDependenciesRepositoryBase<TEntity> : DBVisualMapDependenciesRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DBVisualMapDependenciesRepositoryBase(IDbContextProvider<DBVisualMapDependenciesDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
