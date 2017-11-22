using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Trip.EntityFramework;

namespace Trip.Migrator
{
    [DependsOn(typeof(TripDataModule))]
    public class TripMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TripDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}