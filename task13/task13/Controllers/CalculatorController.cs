using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task13.Models;

namespace task13.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(RandomCalc(new Calculator()));
        }

        [HttpPost]
        public ActionResult Index(Calculator model)
        {
            if (model.UserResult == model.Result)
            {
                ViewBag.PreviousResult = "True";
            }
            else
            {
                ViewBag.PreviousResult = "False";
            }

            model = RandomCalc(model);

            return View(model);
        }

        public Calculator RandomCalc(Calculator calc)
        {
            string[] operation = { "*", "+", "-" };

            Random rand = new Random();
            int firstNumber = rand.Next(0, 10);
            int secondNumber = rand.Next(0, 10);
            string currentOperation = operation[rand.Next(0, 3)];

            calc.FirstNumber = firstNumber;
            calc.SecondNumber = secondNumber;

            if (currentOperation == "*")
            {
                calc.Operation = "*";
                calc.Result = firstNumber * secondNumber;
            }
            if (currentOperation == "-")
            {
                calc.Operation = "-";
                calc.Result = firstNumber - secondNumber;
            }
            if (currentOperation == "+")
            {
                calc.Operation = "+";
                calc.Result = firstNumber + secondNumber;
            }

            return calc;
        }
    }
}