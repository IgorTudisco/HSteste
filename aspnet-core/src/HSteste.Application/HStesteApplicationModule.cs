using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HSteste.Authorization;

namespace HSteste;

[DependsOn(
    typeof(HStesteCoreModule),
    typeof(AbpAutoMapperModule))]
public class HStesteApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<HStesteAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(HStesteApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
