using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using bswing_poc.Models;
using Newtonsoft.Json;


namespace bswing_poc.Controllers
{
    public class MenuController : ApiController
    {
        //MenuItem[] menuItems = new MenuItem[] 
        //{ 
        //    new MenuItem { menuTitle = "People", submenus = [new MenuItem{menuTitle = "This Week"}, new MenuItem{menuTitle = "Next Week"}] }, 
        //    new MenuItem { menuTitle = "Projects" }, 
        //    new MenuItem { menuTitle = "Teams" }
        //};
      

        // GET api/menu
        public List<MenuItem> Get()
        {
            List<MenuItem> items = new List<MenuItem>();

            using (StreamReader r = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/menu.json")))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<MenuItem>>(json);
            }

            return items;
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
