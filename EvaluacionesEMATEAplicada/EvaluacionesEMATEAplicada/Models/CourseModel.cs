using System.Collections.Generic;
namespace EvaluacionesEMATEAplicada.Models
{
    public class CourseModel
    {
        public int classNumber { get; set; }
        public string courseCode { get; set; }
        public UserModel teacher { get; set; }
        public int evaluationsSetType { get; set; }
        public List<StudentModel> studentList { get; set; }
    }
}
