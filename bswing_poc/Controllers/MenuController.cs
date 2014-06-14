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
                       
            List<MenuItem> items = GetDataFromJson<MenuItem>("menu.json");
            List<User> users = GetDataFromJson<User>("users.json");

            var subs = from u in users
                       from usersubscriptions in u.subscriptions
                       join i in items
                       on usersubscriptions.Menu equals i.menuTitle
                       where u.ID == user
                       select i;

            return subs;
        }

        // Get api/menu without user data passed. return null
        public IEnumerable<MenuItem> Get()
        {
            return null; 
        }

        private List<T> GetDataFromJson<T>(string fileName){
            List<T> myList = new List<T>();
            using (StreamReader r = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/" + fileName)))
            {
                string json = r.ReadToEnd();
                myList = JsonConvert.DeserializeObject<List<T>>(json);
            }
            return myList;
        }
    }
}
