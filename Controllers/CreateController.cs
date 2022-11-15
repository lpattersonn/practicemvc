using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practicemvc.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace practicemvc.Controllers
{
    public class CreateController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            CreateViewModel newDog = new CreateViewModel() {Name = "Name", Age = 22 };
            return View(newDog);
        }
    }
}

