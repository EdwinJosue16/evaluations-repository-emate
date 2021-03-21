using System.Collections.Generic;
namespace EvaluacionesEMATEAplicada.Models
{
    public class EvaluationsSetModel
    {
        public int type { get; set; }
        public string courseCode { get; set; }
        public string studentId { get; set; }
        public int courseGroup { get; set; }
        public List<SingleEvaluationModel> singleEvaluations { get; set; }
    }
}
