using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SMS.ALL.EntityFrameworkCore;
using SMS.ALL.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SMS.ALL.Web.Tests
{
    [DependsOn(
        typeof(ALLWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ALLWebTestModule : AbpModule
    {
        public ALLWebTestModule(ALLEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ALLWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ALLWebMvcModule).Assembly);
        }
    }
}