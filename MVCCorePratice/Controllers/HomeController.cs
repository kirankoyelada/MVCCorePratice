using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCorePratice.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCCorePratice.Controllers
{
    public class HomeController:Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new ModelAddress() {
                FirstName="Koyelada",
                LastName="Kiran Kumar"
            };

            return View("Index", model);
        }
    }
}
