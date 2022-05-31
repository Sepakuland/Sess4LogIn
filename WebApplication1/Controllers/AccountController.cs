using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult Process(string username,string password)
        {
            if (username=="admin" && password == "123")
            {
                return RedirectToAction("index", "profile");
            }
            else
            {
                return RedirectToAction("login");
            }
        }
    }
}