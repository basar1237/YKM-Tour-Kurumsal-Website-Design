using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;

namespace ykmturr.Controllers
{
    public class HotelController : Controller
    {   // GET: Populer
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Hotels.ToList();
            return View(degerler);
        }
    }
}