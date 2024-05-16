using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;

namespace ykmturr.Controllers
{
    public class PrivateController : Controller
    {
        // GET: Private
        Context c=new Context();
        public ActionResult Index()
        {
            var degerler = c.Privates.ToList();
            return View(degerler);
        }
        public PartialViewResult PrivateAlt1()
        {

            var degerler = c.Privates.OrderByDescending(x => x.Id).ToList();
            return PartialView(degerler);

        }
    }
}