using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ngocyen.Configuration;

namespace ngocyen.Web.Host.Startup
{
    [DependsOn(
       typeof(ngocyenWebCoreModule))]
    public class ngocyenWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ngocyenWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ngocyenWebHostModule).GetAssembly());
        }
    }
}
