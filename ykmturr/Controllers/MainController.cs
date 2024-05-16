using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;



namespace ykmturr.Controllers
{
    public class MainController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
            {
            var degerler = c.Mains.ToList();
            return View(degerler);
            }
        public PartialViewResult İkonlar()
        {
            var degerler = c.icons.ToList();
            return PartialView(degerler);
        }
        }
    }
