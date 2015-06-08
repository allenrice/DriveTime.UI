using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DriveTime.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new DriveTime.UI.Models.TypeLiteDemoClass()
            {
                BoolProperty = true,
                ListProperty = new List<string>() { "a", "b", "c" },
                MyProperty = Models.TypeLiteDemoEnum.Second,
                NumberProperty = 127001
            });
        }

    }
}