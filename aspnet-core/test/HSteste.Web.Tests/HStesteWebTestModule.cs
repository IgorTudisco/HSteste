using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HSteste.EntityFrameworkCore;
using HSteste.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HSteste.Web.Tests;

[DependsOn(
    typeof(HStesteWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class HStesteWebTestModule : AbpModule
{
    public HStesteWebTestModule(HStesteEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(HStesteWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(HStesteWebMvcModule).Assembly);
    }
}