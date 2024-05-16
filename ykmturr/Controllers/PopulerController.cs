using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;

namespace ykmturr.Controllers
{
    public class PopulerController : Controller
    {   // GET: Populer
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Populers.ToList();
            return View(degerler);
        }
        public PartialViewResult Fiyat()
        {
            var degerler=c.Fiyats.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Yıldızlar()
        {
            var degerler = c.Yıldızlars.ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Yatak()
        {
            var degerler = c.Yataks.ToList();
            return PartialView(degerler);
        }
    }
}