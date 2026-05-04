using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ngocyen.EntityFrameworkCore;
using ngocyen.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ngocyen.Web.Tests
{
    [DependsOn(
        typeof(ngocyenWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ngocyenWebTestModule : AbpModule
    {
        public ngocyenWebTestModule(ngocyenEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ngocyenWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ngocyenWebMvcModule).Assembly);
        }
    }
}