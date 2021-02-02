using ABP.WebProject.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.Web.Host.Controllers
{
    [Route("api/[controller]")]
    public class TestController : JQWebControllerBase
    {
        public object Get(int i)
        {
            return new { i, time = DateTime.Now };
        }
    }
}
