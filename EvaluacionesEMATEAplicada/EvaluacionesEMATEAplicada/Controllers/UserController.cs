using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EvaluacionesEMATEAplicada.Models;

namespace EvaluacionesEMATEAplicada.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserModel user)
        {
            return RedirectToAction("Index","Home");
        }
    }
}