using System.ComponentModel.DataAnnotations;
namespace EvaluacionesEMATEAplicada.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Es necesario que ingrese el nombre del estudiante")]
        [Display(Name = "Nombre del estudiante: ")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Es necesario que ingrese el primer apellido del estudiante")]
        [Display(Name = "Primer apellido del estudiante: ")]
        public string firstLastName { get; set; }

        [Required(ErrorMessage = "Es necesario que ingrese el segundo apellido del estudiante")]
        [Display(Name = "Segundo apellido del estudiante: ")]
        public string secondLastName { get; set; }

        [Required(ErrorMessage = "Es necesario que ingrese el número de carné del estudiante")]
        [Display(Name = "Número de carné del estudiante: ")]
        public string id { get; set; }
    }
}
