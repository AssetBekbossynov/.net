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
    public class RouteController : Controller{

        public IActionResult RouteList(){
            // throw new NotImplementedException();
            var value = RouteManager.showRoute();
            return View(value);
        }

    }
}