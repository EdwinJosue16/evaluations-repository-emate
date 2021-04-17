using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EvaluacionesEMATEAplicada.Models;
using EvaluacionesEMATEAplicada.Repositories;

namespace EvaluacionesEMATEAplicada.Controllers
{
    public class CourseEvaluationsController : Controller
    {
        private StudentsRepository StudentsRepo;

        public CourseEvaluationsController()
        {
            StudentsRepo = new StudentsRepository();
        }

        public IActionResult ListOfTheClass(string courseCode, int classNumber) {
            CourseModel course = new CourseModel
            {
                classNumber = classNumber,
                courseCode = courseCode,
                teacher = new TeacherModel(), // NO ES UTILIZADO ACTUALMENTE,
                studentList = StudentsRepo.GetAll()
            };
            ViewBag.myCourse = course;
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ModifyEvalutionOf(string studentId, string courseCode, int classNumber)
        {
            /*
             ESTE METODO CONTIENE DATOS DUMMIE, LA IDEA ES TRAER LA INFORMACIÓN DESDE LA BASE DE DATOS
             UTILIZANDO LOS PARAMETROS RECIBIDOS
             */

            EvaluationsSetModel evaluations = new EvaluationsSetModel
            {
                courseCode = courseCode,
                studentId = studentId,
                courseGroup = classNumber,
                type = 1234,

                singleEvaluations = new List<SingleEvaluationModel>
                {
                    new SingleEvaluationModel
                    {
                        type = "Parcial I",
                        evaluationGrade = 45.6,
                        percent = 33.33
                    },

                    new SingleEvaluationModel
                    {
                        type = "Parcial II",
                        evaluationGrade = 90.0,
                        percent = 33.33
                    },
                    new SingleEvaluationModel
                    {
                        type = "Parcial III",
                        evaluationGrade = 100.0,
                        percent = 33.33
                    }
                }
            };

            return View(evaluations);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SaveEvaluation(EvaluationsSetModel model)
        {
            //ESTE METODO SERA PARA CREAR NUEVOS CONJUNTOS DE EVALUACIONES
            return View();
        }
    }
}