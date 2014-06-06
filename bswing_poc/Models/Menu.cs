using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bswing_poc.Models
{
    public class MenuItem
    {
        public string menuTitle { get; set; }
        public MenuItem[] submenus { get; set; }
    }
}
