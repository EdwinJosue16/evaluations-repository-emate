using System.ComponentModel.DataAnnotations;
namespace EvaluacionesEMATEAplicada.Models
{
    public class SingleEvaluationModel
    {
        [Required(ErrorMessage = "Es elegir un tipo de evaluación")]
        [Display(Name = "Seleccione el tipo de evaluación")]
        public string type { get; set; }

        [Required(ErrorMessage = "Es necesario que llene el espacio de la nota")]
        [Range(0,100, ErrorMessage = "La nota debe ser un número entre 0 y 100")]
        [Display(Name = "Ingrese la nota para esta evaluación (entre 0 y 100)")]
        public double evaluationGrade { set; get; }

        [Required(ErrorMessage = "Es necesario que llene el espacio de la evaluación")]
        [Range(0, 100, ErrorMessage = "El porcentaje debe ser un entre 0% y 100%")]
        [Display(Name = "Ingrese el porcentaje para esta evaluación (entre 0 y 100)")]
        public double percent { get; set; }
    }
}
