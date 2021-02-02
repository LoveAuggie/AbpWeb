using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.WebProject.Core;
using ABP.WebProject.Core.Configuration;

namespace ABP.WebProject.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpWeb_JQModule))]
    public class JQWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JQWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JQWebHostModule).GetAssembly());
        }
    }
}
