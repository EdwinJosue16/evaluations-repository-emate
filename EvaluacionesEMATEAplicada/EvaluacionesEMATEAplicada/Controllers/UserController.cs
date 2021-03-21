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
            if (TempData["Message"] != null)
            {
                ViewBag.Message = TempData["Message"].ToString();
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(UserModel user)
        {
            bool condition = user.email=="admin" && user.password=="asdfghjkl1234!";
            if (condition){
                @TempData["Message"] = user.email;
                return RedirectToAction("ListOfCourses", "User");
            }
            else {
                @TempData["Message"] = "Error de autenticación, algunos datos son incorrectos";
                return RedirectToAction("Login", "User");
            }

        }

        public IActionResult ListOfCourses() {

            ViewBag.LoginCondition = false;
            if (TempData["Message"] != null){
                ViewBag.Message = TempData["Message"].ToString();
                ViewBag.LoginCondition = true;
            }
            return View();
        }
    }
}