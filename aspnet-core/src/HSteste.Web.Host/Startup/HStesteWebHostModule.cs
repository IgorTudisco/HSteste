using Abp.Modules;
using Abp.Reflection.Extensions;
using HSteste.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace HSteste.Web.Host.Startup
{
    [DependsOn(
       typeof(HStesteWebCoreModule))]
    public class HStesteWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HStesteWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HStesteWebHostModule).GetAssembly());
        }
    }
}
