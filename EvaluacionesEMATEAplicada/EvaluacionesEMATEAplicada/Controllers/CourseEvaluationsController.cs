using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EvaluacionesEMATEAplicada.Models;
using Microsoft.Extensions.Configuration;
using EvaluacionesEMATEAplicada.Models.Handlers;

namespace EvaluacionesEMATEAplicada.Controllers
{
    public class CourseEvaluationsController : Controller
    {
        private readonly IConfiguration configuration;
        private CourseEvaluationHandler dbContext;

        public CourseEvaluationsController(IConfiguration configuration)
        {
            this.configuration = configuration;
            dbContext = new CourseEvaluationHandler(configuration);

        }

        public IActionResult ListOfTheClass(string courseCode, int classNumber) {
            StudentModel tempStudent = new StudentModel();
            List<StudentModel> listOfStudents = new List<StudentModel>();
            UserModel teacher = new UserModel();
            CourseModel course = new CourseModel();
            course.classNumber = classNumber;
            course.courseCode = courseCode;
            course.teacher = teacher;
            course.studentList = dbContext.GetStudents();
            ViewBag.myCourse = course;
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ModifyEvalutionOf(int type, string studentId, string courseCode, int classNumber)
        {
            EvaluationsSetModel evaluationsOFStudent = dbContext.EvaluationsSet1OfStudent(studentId, courseCode, classNumber);
            return View(evaluationsOFStudent);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEvaluation(EvaluationsSetModel model)
        {
            return View();
        }
    }
}