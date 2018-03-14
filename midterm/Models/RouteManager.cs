using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models{
    public class RouteManager{
        
        static readonly string routePath = "Data/Route.csv";

        public static List<Route> showRoute(){
            var routeStore = new RouteStore() { Path = routePath };
            var routeList = routeStore.GetCollection();

            return routeList;
        }
    }
}