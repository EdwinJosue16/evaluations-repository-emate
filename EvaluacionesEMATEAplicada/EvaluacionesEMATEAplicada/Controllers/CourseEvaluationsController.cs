using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EvaluacionesEMATEAplicada.Models;


namespace EvaluacionesEMATEAplicada.Controllers
{
    public class CourseEvaluationsController : Controller
    {
        public IActionResult ListOfTheClass(string courseCode, int classNumber){
            StudentModel tempStudent=new StudentModel();
            List<StudentModel> listOfStudents=new List<StudentModel>();
            UserModel teacher=new UserModel();
            CourseModel course = new CourseModel();

            for (int i = 0; i < 30; ++i) {
                listOfStudents.Add(
                    new StudentModel
                    {

                        firstName = "Generic",
                        firstLastName = "Student",
                        secondLastName = "Demo",
                        id = "BXXX" + i.ToString()
                    });
            }
            course.classNumber = classNumber;
            course.courseCode = courseCode;
            course.studentList = listOfStudents;
            course.teacher = teacher;
            ViewBag.myCourse = course;
            return View();
        }
    }
}