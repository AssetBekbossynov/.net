using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace midterm.Models{
    public class ReportManager{
        
        public static List<JoinedOrderDetail> SortByGivenPath(string Path){

            var sorted = OrderDetailManager.showOrderDetail()
                .Where(x=>x.Path.Equals(Path))
                .ToList();
            
            return sorted;
        }
        public static List<JoinedOrderDetail> SortByStatus(string Status){

            var sorted = OrderDetailManager.showOrderDetail()
                .Where(x=>x.Status.Equals(Status))
                .ToList();
            
            return sorted;
        }

        public static List<JoinedOrderDetail> OrderByCost(){
            var sorted = OrderDetailManager.showOrderDetail()
                .OrderBy(x=>x.TotalCost)
                .ToList();
                
            return sorted;
        }
        public static List<JoinedOrderDetail> OrderByLoadId(){
            return OrderDetailManager.showOrderDetail()
                .OrderBy(x=>x.LoadId)
                .ToList();
        }

        // public static List<JoinedOrderDetail> sortByDate(string firstDate, string secondDate){
        //     DateTime date = new DateTime();
        //     date.ToString("dd.MM.yy");
        //     DateTime date1 = DateTime.ParseExact(firstDate, "dd.MM.yy", CultureInfo.InvariantCulture);
        //     DateTime date2 = DateTime.ParseExact(secondDate, "dd.MM.yy", CultureInfo.InvariantCulture);

        //     DateTime date3 = DateTime.ParseExact( OrderDetailManager.showOrderDetail()
        //         .Select(x=>x.OrderDate).ToString() , "dd.MM.yy", CultureInfo.InvariantCulture);
            

        // }
    }
}