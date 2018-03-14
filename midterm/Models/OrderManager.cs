using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using midterm.Models;
using System.Linq;

namespace midterm.Models{
    public class OrderManager{
        
        static readonly string orderPath = "Data/Order.csv";
        static readonly string routePath = "Data/Route.csv";

        public static List<JoinedOrder> showOrder(){
            var orderStore = new OrderStore() { Path = orderPath };
            var orderList = orderStore.GetCollection();
            var routeStore = new RouteStore() { Path = routePath };
            var routeList = routeStore.GetCollection();

            var orderAndLoad = orderList
                .Join(LoadManager.showLoad(), order=>order.LoadId, load=>load.Id, (order, load) => new
                {
                    order,
                    load
                })
                .Join(routeList, order=>order.order.RouteId, route=>route.Id, (order, route) => new JoinedOrder
                {
                    Id = order.order.Id,
                    Path = route.Path, 
                    LoadId = order.load.Id,
                    Category = order.load.Description,
                    Phone = order.load.Phone,
                    OrderDate = order.order.OrderDate,
                    DeliveryDate = order.order.DeliveryDate,
                    TotalCost = order.order.TotalCost,
                })
                .ToList();
            
            return orderAndLoad;
        }
    }
}