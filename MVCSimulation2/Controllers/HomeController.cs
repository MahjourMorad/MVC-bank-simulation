using System;-000000000000000000

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCSimulation2.Models;

namespace MVCSimulation2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                double loanAmount = Double.Parse(Request.Form["loanAmount"]);
                double loanTerm = Double.Parse(Request.Form["loanterm"]);
                double interestRate = Double.Parse(Request.Form["interestRate"]);
                double result;
                String min_btn = Request.Form["min_btn"];
                LoanBusinessLayer loanbusinesslayer = new LoanBusinessLayer();
                ViewData["loanAmount"] = $"{loanAmount}";
                ViewData["loanTerm"] = $"{loanTerm}";
                ViewData["interestRate"] = $"{interestRate}";
                Loan loan = new Loan();
                result = loanbusinesslayer.CalculMensualite(loanAmount, loanTerm,
               interestRate);
                ViewData["result"] = result;

            }
            catch (NullReferenceException e)
            {
            }
            catch (InvalidOperationException e) { }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
