using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EvaluacionesEMATEAplicada.Models;

namespace EvaluacionesEMATEAplicada.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserModel user)
        {
            @TempData["Message"] = user.email;
            return RedirectToAction("Index","Home");
        }
    }
}