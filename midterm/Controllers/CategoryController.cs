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
    public class CategoryController : Controller{

        public IActionResult CategoryList(){
            //throw new NotImplementedException();
            var value = CategoryManager.showCategory();
            return View(value);
        }

    }
}