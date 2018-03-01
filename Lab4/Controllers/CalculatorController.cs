using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Calc(){
           
            var calc = new Calculator()
            {
                Operand1 = 0,
                Operator = "+",
                Operand2 = 0,
                Answer = 0
            };
            return View(calc);
       }
    }
}
