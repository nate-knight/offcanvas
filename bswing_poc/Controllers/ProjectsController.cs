using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bswing_poc.Controllers
{
    public class ProjectsController : Controller
    {
        //
        // GET: /Projects/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WholeFoods()
        {
            return View();
        }

        public ActionResult CookWithMe()
        {
            return View();
        }
        public ActionResult AnotherProject()
        {
            return View();
        }
        
    }
}
