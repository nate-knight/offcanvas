using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bswing_poc.Models
{
    public class User
    {
        public string ID { get; set; }
        public Subscription[] subscriptions { get; set; }
    }

    public class Subscription
    {
        public string Menu { get; set; }
    }
}