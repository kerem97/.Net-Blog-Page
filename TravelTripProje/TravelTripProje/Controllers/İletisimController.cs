using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Controllers
{
    public class İletisimController : Controller
    {
        // GET: İletisim
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.İletisims.ToList();
            return View(degerler);
        }

    }
}