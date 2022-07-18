using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_core_MVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> options = new List<string>();

            options.Add("Select an Option");

            options.Add("Yes");
            options.Add("No");


            ViewData["options"] = new SelectList(options);

            return View();
        }



        [HttpPost]
        public IActionResult PersonalDetails(IFormCollection form, ICollection<string> hobbies)
        {

            ViewBag.Name = form["username"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Hobbies = hobbies;
            ViewBag.Option = form["options"];
            return View("Display");
        }


}
}