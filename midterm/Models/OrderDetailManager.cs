using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models{
    public class OrderDetailManager{
        
        static readonly string orderDetailPath = "Data/OrderDetail.csv";
        static readonly string orderPath = "Data/Order.csv";

        public static List<JoinedOrderDetail> showOrderDetail(){
            var orderDetailStore = new OrderDetailStore() { Path = orderDetailPath };
            var orderDetailList = orderDetailStore.GetCollection();

             var joinedOrderDetail = orderDetailList
                .Join(OrderManager.showOrder(), detail=>detail.OrderId, order=>order.Id, (detail, order) => new JoinedOrderDetail
                {
                    Id = detail.Id,
                    Path = order.Path, 
                    LoadId = order.LoadId,
                    Category = order.Category,
                    Phone = order.Phone,
                    OrderDate = order.OrderDate,
                    DeliveryDate = order.DeliveryDate,
                    TotalCost = order.TotalCost,
                    Status = detail.Status,
                })
                .ToList();
            
            return joinedOrderDetail;
        }
    }
}