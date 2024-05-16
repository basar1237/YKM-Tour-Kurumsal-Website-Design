using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;

namespace ykmturr.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Populer()
        {
            return View();
        }
        public ActionResult Recent()
        {
            return View();
        }
        public ActionResult Private()
        {
            return View();
        }
        public ActionResult Corporate()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}