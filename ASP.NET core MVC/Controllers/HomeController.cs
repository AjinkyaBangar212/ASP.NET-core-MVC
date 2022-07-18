using ASP.NET_core_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;



namespace ASP.NET_core_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AboutUs()  // adding new custom action
        {
            return View();
        }

        public IActionResult ContactUs()  // adding new custom action
        {
            return View();
        }


        public IActionResult Index()
        {

            ViewData["message"] = "This Is MVC Application";
            string[] names = { "Ajinkya", "Shweta", "Rushika" };

            ViewData["names"] = names;

            List<Employee> emplist = new List<Employee>()
            { 
            
                new Employee{ Id = 1 , Name = "Ajit" , Department= "It" , Salary = 25000},
                new Employee{ Id = 2 , Name = "Amey" , Department= "It" , Salary = 30000},
                new Employee{ Id = 3 , Name = "Aniket" , Department= "It" , Salary = 35000}

            };

            ViewData["emplist"] = emplist ;

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
