using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult Add(User newUser, string confirm)
        {
            ViewBag.user = newUser;
            if (newUser.Password == confirm)
            {
                return View("index");
            }
            else
            {
                ViewBag.error = "The Passwords do not match";
                return View();
            }
            
        }
    }
}
