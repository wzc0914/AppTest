using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Trip.EntityFramework.Repositories
{
    public abstract class TripRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TripDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TripRepositoryBase(IDbContextProvider<TripDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TripRepositoryBase<TEntity> : TripRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TripRepositoryBase(IDbContextProvider<TripDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
