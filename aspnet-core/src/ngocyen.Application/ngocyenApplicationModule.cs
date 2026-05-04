using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ngocyen.Authorization;

namespace ngocyen
{
    [DependsOn(
        typeof(ngocyenCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ngocyenApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ngocyenAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ngocyenApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
