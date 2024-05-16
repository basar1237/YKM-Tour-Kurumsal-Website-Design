using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ykmturr.Models.Sınıflar;

namespace ykmturr.Controllers
{
    public class TripController : Controller
    {
        // GET: Trip
        Context c = new Context();
        public ActionResult Trip()
        {
            var degerler = c.Trips.ToList();
            return View(degerler);
        }
    }
}