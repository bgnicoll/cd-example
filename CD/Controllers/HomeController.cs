using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace CD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var connectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
            return View(model: connectionString);
        }
    }
}