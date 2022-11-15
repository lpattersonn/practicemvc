using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicemvc.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace practicemvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel() { Name = "Styk", Age = 22 };

            return View(doggo);

        }

        public string Hello() 
        {
            return "Who's there?";
        }
    }
}

