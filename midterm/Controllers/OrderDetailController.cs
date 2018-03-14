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
    public class OrderDetailController : Controller{

        public IActionResult OrderDetailList(){
            // throw new NotImplementedException();
            var value = OrderDetailManager.showOrderDetail();
            return View(value);
        }

    }
}