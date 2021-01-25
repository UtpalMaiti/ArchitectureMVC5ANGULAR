using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SMS.ALL.Configuration;

namespace SMS.ALL.Web.Host.Startup
{
    [DependsOn(
       typeof(ALLWebCoreModule))]
    public class ALLWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ALLWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ALLWebHostModule).GetAssembly());
        }
    }
}
