using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP.WebProject.Core;
using ABP.WebProject.Core.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.Web.Host
{
    [DependsOn(typeof(AbpWeb_JQModule))]
    class WebHost_JQModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WebHost_JQModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebHost_JQModule).GetAssembly());
        }
    }
}
