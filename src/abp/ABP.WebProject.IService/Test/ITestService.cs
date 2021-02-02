using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.IService.Test
{
    public interface ITestService : IApplicationService
    {
        object GetOne(string i);
    }
}
