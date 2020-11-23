using System.Collections.Generic;
using student_id_t = System.String;
namespace EvaluacionesEMATEAplicada.Models
{
    public class CourseModel
    {
        public int classNumber { get; set; }
        public string courseCode { get; set; }
        public List<StudentModel> studentList { get; set; }
        public UserModel teacher { get; set; }
        public int evaluationsSetType { get; set; }
        public Dictionary<student_id_t, EvaluationsSetModel> courseResults { get; set; }
    }
}
