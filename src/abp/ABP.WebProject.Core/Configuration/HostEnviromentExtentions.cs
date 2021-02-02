using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ABP.WebProject.Core.Configuration
{
    public static class HostEnviromentExtentions
    {
        public static IConfigurationRoot GetAppConfiguration(this IWebHostEnvironment env)
        {
            return AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName, env.IsDevelopment());
        }
    }
}
