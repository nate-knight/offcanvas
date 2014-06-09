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
   
        // GET api/menu
        public IEnumerable<MenuItem> Get(string user)
        {
            List<MenuItem> items = new List<MenuItem>();
            List<User> users = new List<User>();

            using (StreamReader r = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/menu.json")))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<MenuItem>>(json);
            }

            using (StreamReader r = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/users.json")))
            {
                string json = r.ReadToEnd();
                users = JsonConvert.DeserializeObject<List<User>>(json);
            }

            var subs = from u in users
                       from usersubscriptions in u.subscriptions
                       join i in items
                       on usersubscriptions.Menu equals i.menuTitle
                       where u.ID == user
                       select i;

      
            return subs;
        }

    }
}
