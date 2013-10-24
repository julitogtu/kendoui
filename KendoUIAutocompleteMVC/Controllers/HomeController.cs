using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using KendoUIAutocompleteMVC.Models;

namespace KendoUIAutocompleteMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Country> countries = new List<Country>(){
            new Country { CountryId = 1, Name = "Colombia"},
            new Country { CountryId = 2, Name = "Argentina"},
            new Country { CountryId = 3, Name = "Brazil"},
            new Country { CountryId = 4, Name = "Bolivia"},
            new Country { CountryId = 5, Name = "España"},
            new Country { CountryId = 6, Name = "Chile"},
            new Country { CountryId = 7, Name = "Francia"},
            new Country { CountryId = 8, Name = "Alemania"},
            new Country { CountryId = 9, Name = "Italia"},
            new Country { CountryId = 10, Name = "China"}
        };

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCountries()
        {
            return Json(countries.ToList(), JsonRequestBehavior.AllowGet);
        }

    }
}