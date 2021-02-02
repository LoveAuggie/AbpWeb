using ABP.WebProject.Core.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.Web.Host.Controllers
{
    public class TestController : JQWebControllerBase
    {
        public object Get(int i)
        {
            return new { i, time = DateTime.Now };
        }
    }
}
