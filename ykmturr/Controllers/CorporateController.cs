using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;


namespace ykmturr.Controllerss
{
    public class CorporateController : Controller
    {
        // GET: Corporate
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler=c.Corporates.ToList();
            return View(degerler);
        }
    }
}