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
    public class OrderController : Controller{

        public IActionResult OrderList(){
            // throw new NotImplementedException();
            var value = OrderManager.showOrder();
            return View(value);
        }

    }
}