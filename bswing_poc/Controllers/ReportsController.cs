using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bswing_poc.Controllers
{
    public class ReportsController : Controller
    {
        //
        // GET: /Reports/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProjectPerformance()
        {
            return View();
        }
        public ActionResult TeamPerformance()
        {
            return View();
        }
        public ActionResult Projections()
        {
            return View();
        }
    }
}
