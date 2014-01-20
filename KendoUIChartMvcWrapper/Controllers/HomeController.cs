using System;
using KendoUIChartMvcWrapper.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace KendoUIChartMvcWrapper.Controllers
{
    public class HomeController : Controller
    {

        private List<Values> values = new List<Values>() 
        { 
            new Values (){ Id = 1, Date = DateTime.Now, Value = 10},
            new Values (){ Id = 2, Date = DateTime.Now.AddMinutes(10), Value = 5},
            new Values (){ Id = 2, Date = DateTime.Now.AddMinutes(20), Value = 15},
            new Values (){ Id = 2, Date = DateTime.Now.AddMinutes(30), Value = 0},
            new Values (){ Id = 2, Date = DateTime.Now.AddMinutes(40), Value = 20}
        };

        public ActionResult Index()
        {
            return View(values);
        }
    }
}