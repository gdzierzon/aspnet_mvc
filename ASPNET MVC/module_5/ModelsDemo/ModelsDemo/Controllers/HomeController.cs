using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelsDemo.Models;

namespace ModelsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Calculator calculator)
        {
            if (calculator.Operation == "Divide" && calculator.NumberTwo == 0)
            {
                ModelState.AddModelError("NumberTwo", "You shouldn't be dividing by Zero.");
            }

            if (ModelState.IsValid)
            {
                //save to database
            }

            return View(calculator);
        }

        public ActionResult CalculatorList()
        {
            List<Calculator> calculators = new List<Calculator>();
            calculators.Add(new Calculator() { NumberOne = 12, NumberTwo = 3, Operation = "Add" });
            calculators.Add(new Calculator() { NumberOne = 65, NumberTwo = 15, Operation = "Multiply" });
            calculators.Add(new Calculator() { NumberOne = 2, NumberTwo = 345, Operation = "Subtract" });
            calculators.Add(new Calculator() { NumberOne = 82, NumberTwo = 9, Operation = "Divide" });
            calculators.Add(new Calculator() { NumberOne = 123, NumberTwo = 21, Operation = "Add" });

            return View(calculators);

        }
    }
}