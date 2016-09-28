using System.Data.Common;
using Abp.Zero.EntityFramework;
using FlightParking.Authorization.Roles;
using FlightParking.MultiTenancy;
using FlightParking.Users;

namespace FlightParking.EntityFramework
{
    public class FlightParkingDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public FlightParkingDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in FlightParkingDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of FlightParkingDbContext since ABP automatically handles it.
         */
        public FlightParkingDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public FlightParkingDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
