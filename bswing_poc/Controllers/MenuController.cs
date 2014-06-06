using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using bswing_poc.Models;


namespace bswing_poc.Controllers
{
    public class MenuController : ApiController
    {
        MenuItem[] menuItems = new MenuItem[] 
        { 
            new MenuItem { Title = "People" }, 
            new MenuItem { Title = "Projects" }, 
            new MenuItem { Title = "Teams" }
        };

        // GET api/menu
        public IEnumerable<MenuItem> Get()
        {
            return menuItems;
        }

       

//public JsonResult Get()
  //      {
            //var items = new List<Menu>();

            //movies.Add(new { Title = "Ghostbusters", Genre = "Comedy", Year = 1984 });
            //movies.Add(new { Title = "Gone with Wind", Genre = "Drama", Year = 1939 });
            //movies.Add(new { Title = "Star Wars", Genre = "Science Fiction", Year = 1977 });

            //items.Add(new { Title = "People", Submenu = ""});

            //var fileContents = System.IO.File.ReadAllText(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/menu.json"));
          //  return new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(new { fileContents });
            //return  Json(fileContents);
    //    }

      

        // GET api/menu/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/menu
        public void Post([FromBody]string value)
        {
        }

        // PUT api/menu/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/menu/5
        public void Delete(int id)
        {
        }
    }
}
