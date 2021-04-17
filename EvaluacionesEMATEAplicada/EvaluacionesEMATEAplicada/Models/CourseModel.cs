using System.Collections.Generic;
namespace EvaluacionesEMATEAplicada.Models
{
    public class CourseModel
    {
        public int classNumber { get; set; }
        public string courseCode { get; set; }
        public TeacherModel teacher { get; set; }
        public int evaluationsSetType { get; set; } //Se corresponde con el "tipo" de conjunto de evaluaciones que usa el curso, se corresponde con el tipo del modelo EvaluationsSetModel
        public IEnumerable<StudentModel> studentList { get; set; }


        /*
         classNumber: número de grupo del curso en cuestión
         courseCode: es el código, ejemplo, MA4561
         teacher: contiene los datos del docente que imparte el curso
         evaluationsSetType: Se corresponde con el "tipo" de conjunto de evaluaciones que usa el curso,
         se corresponde con el tipo del modelo EvaluationsSetModel
         studentList: contiene la información de los estudiantes del curso
         */
    }
}
