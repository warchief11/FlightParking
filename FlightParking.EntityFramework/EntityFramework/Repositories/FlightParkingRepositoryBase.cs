using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace FlightParking.EntityFramework.Repositories
{
    public abstract class FlightParkingRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<FlightParkingDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected FlightParkingRepositoryBase(IDbContextProvider<FlightParkingDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class FlightParkingRepositoryBase<TEntity> : FlightParkingRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected FlightParkingRepositoryBase(IDbContextProvider<FlightParkingDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
