using ABP.WebProject.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP.WebProject.Web.Host.Controllers
{
    public class HomeController: JQWebControllerBase
    {
        public HomeController() { }

        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
