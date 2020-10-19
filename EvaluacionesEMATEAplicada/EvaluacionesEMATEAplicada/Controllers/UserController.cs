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
            bool condition = true;
            if (condition){
                @TempData["Message"] = user.email;
                return RedirectToAction("ListOfCourses", "User");
            }
            else {
                @TempData["Message"] = user.email;
                return RedirectToAction("Index", "Home");
            }

        }

        public IActionResult ListOfCourses() {
            if (TempData["Message"] != null){

                ViewBag.Message = TempData["Message"].ToString();
            }
            return View();
        }
    }
}