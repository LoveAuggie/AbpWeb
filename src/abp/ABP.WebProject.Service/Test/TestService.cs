using ABP.WebProject.IService.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.Service.Test
{
    public class TestService : ITestService
    {
        public object GetOne(string i)
        {
            return new { one = i };
        }
    }
}
