using ASP.NET_core_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_core_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {


            List<Product> plist = new List<Product>()
            {
                new Product{ Id = 101, Name="Hp Laptop" , Price= 55000 },
                new Product{ Id = 102, Name="Dell Laptop" , Price= 45000 },
                new Product{ Id = 103, Name="Lenovo Laptop" , Price= 35000 },
                new Product{ Id = 104, Name="Apple Laptop" , Price= 95000 },
                new Product{ Id = 105, Name="Iball Laptop" , Price= 55000 },
            };

            ViewBag.ProductList = plist;

            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(IFormCollection form)
        {

            ViewBag.Id = form["pid"];
            ViewBag.Name = form["pname"];
            ViewBag.Price = form["price"];

            return View("Details");
        }


    }
}
