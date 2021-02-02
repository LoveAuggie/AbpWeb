using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero;
using Abp.Zero.Configuration;
using ABP.WebProject.Core.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace ABP.WebProject.Core
{
    // Core模块
    [DependsOn(
        typeof(AbpAspNetCoreModule))]
    public class AbpWeb_JQModule : AbpModule // 模块化的定义，WebCore模块
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpWeb_JQModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();

            //Configuration.Auditing.IsEnabledForAnonymousUsers = false;
            //Configuration.MultiTenancy.IsEnabled = false;
        }

        public override void PreInitialize()
        {
            //Configuration.Authorization.Providers.Add<>
            base.PreInitialize();
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString("Default");

            // Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            //Configuration.Modules.AbpAspNetCore()
            //     .CreateControllersForAppServices(
            //         typeof(MyFirstProjectApplicationModule).GetAssembly()
            //     );
        }

        public override void Initialize()
        {
            // 固定写法，注册所有依赖
            IocManager.RegisterAssemblyByConvention(typeof(AbpWeb_JQModule).GetAssembly());
        }
    }
}
