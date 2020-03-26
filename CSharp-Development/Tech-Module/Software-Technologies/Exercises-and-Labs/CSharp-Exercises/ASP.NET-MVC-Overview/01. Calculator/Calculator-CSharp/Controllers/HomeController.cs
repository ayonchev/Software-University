using System;
using System.Web.Mvc;
using Calculator_CSharp.Models;

namespace Calculator_CSharp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public ActionResult Calculate(Calculator calculator)
        {
            calculator.Result = CalculateResult(calculator);

            return RedirectToAction("Index", calculator);
        }

        private decimal CalculateResult(Calculator calculator)
        {
            var result = 0m;

            switch (calculator.Operator)
            {
                case "+":
                    result = calculator.LeftOperand + calculator.RightOperand;
                    break;
                case "-":
                    result = calculator.LeftOperand - calculator.RightOperand;
                    break;
                case "*":
                    result = calculator.LeftOperand * calculator.RightOperand;
                    break;
                case "/":
                    result = calculator.LeftOperand / calculator.RightOperand;
                    break;
                case "%":
                    decimal percents = calculator.LeftOperand / 100;
                    result = percents * calculator.RightOperand;
                    break;
                case "^":
                    int power = (int)calculator.RightOperand;
                    result = 1;

                    for (int i = 0; i < (int)(Math.Abs(power)); i++)
                    {
                        result *= calculator.LeftOperand;
                    }

                    if (power < 0)
                    {
                        result = 1 / result;

                    }
                    
                    break;
            }

            return result;
        }
    }
}