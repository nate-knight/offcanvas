using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bswing_poc.Controllers
{
    public class PeopleController : Controller
    {
        //
        // GET: /People/

        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult ThisWeek()
        {
            return View();
        }

        public ActionResult OverUnderReport()
        {
            return View();
        }

        public ActionResult ByPerson()
        {
            return View();
        }

    }
}
