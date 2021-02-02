using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System;

namespace ABP.WebProject.Web.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }



        public static IWebHost BuildWebHost(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<StartUp>()
                .Build();
        }
    }
}
