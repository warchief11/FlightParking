using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using FlightParking.EntityFramework;

namespace FlightParking.Migrator
{
    [DependsOn(typeof(FlightParkingDataModule))]
    public class FlightParkingMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FlightParkingDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}