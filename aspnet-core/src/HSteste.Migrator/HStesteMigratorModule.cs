using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HSteste.Configuration;
using HSteste.EntityFrameworkCore;
using HSteste.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace HSteste.Migrator;

[DependsOn(typeof(HStesteEntityFrameworkModule))]
public class HStesteMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public HStesteMigratorModule(HStesteEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(HStesteMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            HStesteConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(HStesteMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
