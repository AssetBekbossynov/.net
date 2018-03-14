using System;
using midterm.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Text;
using System.Linq;
using midterm.Models;
using System.Text.Encodings.Web;
using System.Diagnostics;
using System.Threading.Tasks;

namespace midterm.Controllers{
    public class ReportController : Controller{

        public IActionResult ReportByPath(string path){
            // throw new NotImplementedException();
            var value = ReportManager.SortByGivenPath(path);
            return View(value);
        }
        public IActionResult ReportByStatus(string status){
            // throw new NotImplementedException();
            var value = ReportManager.SortByStatus(status);
            return View(value);
        }
        public IActionResult ReportOrderByCost(){
            // throw new NotImplementedException();
            var value = ReportManager.OrderByCost();
            return View(value);
        }
        public IActionResult ReportOrderByLoadId(string status){
            // throw new NotImplementedException();
            var value = ReportManager.OrderByLoadId();
            return View(value);
        }
    }
}