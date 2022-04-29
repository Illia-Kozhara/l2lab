using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using L2Lab.Configuration;

namespace L2Lab.Web.Host.Startup
{
    [DependsOn(
       typeof(L2LabWebCoreModule))]
    public class L2LabWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public L2LabWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(L2LabWebHostModule).GetAssembly());
        }
    }
}
