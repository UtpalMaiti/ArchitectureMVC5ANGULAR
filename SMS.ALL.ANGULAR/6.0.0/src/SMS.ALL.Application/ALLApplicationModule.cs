using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SMS.ALL.Authorization;

namespace SMS.ALL
{
    [DependsOn(
        typeof(ALLCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ALLApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ALLAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ALLApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
