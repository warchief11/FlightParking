using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using FlightParking.EntityFramework;

namespace FlightParking
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(FlightParkingCoreModule))]
    public class FlightParkingDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<FlightParkingDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
