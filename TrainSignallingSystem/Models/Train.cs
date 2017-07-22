using System;
using System.Collections.Generic;
namespace Models
{
    public class Train{
        public string Name {get;set;}
        public List<Route> Routes {get;set;}
        public Station CurrentStation {get; set;}
    }
}