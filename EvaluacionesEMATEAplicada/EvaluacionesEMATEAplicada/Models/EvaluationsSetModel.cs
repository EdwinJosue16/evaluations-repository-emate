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

    /*
     Esta clase tiene el proposito de ser un conjunto de evaluciones que se comporte de manera dinámica.
     Por ejemplo, si un curso MA0001 tiene la siguiente evaluación:
     3 examenes de 30% cada uno
     2 quices de 5% cada uno

    Y supongamos que en el curso MA0001 grupo 100 está matriculado Juan Arias carné B00000, entonces podemos representar
    las evaluaciones de Juan con este modelo:


    type: algún número (ver nota al final)
    courseCode: MA0001
    studentId: B00000
    courseGroup: 100
    singleEvaluations: Lista con 5 SingleEvaluationModel, donde cada objeto de la lista sería así:
    {
        type = Parcial I
        evaluationGrade = 74 (por ejemplo)
        percent = 30 
    }    

    {
        type = Parcial II
        evaluationGrade = 79 (por ejemplo)
        percent = 30 
    }    

    {
        type = Parcial III
        evaluationGrade = 89 (por ejemplo)
        percent = 30 
    }

    {
        type = Quiz I
        evaluationGrade = 89 (por ejemplo)
        percent = 5 
    }

    {
        type = Quiz II
        evaluationGrade = 90 (por ejemplo)
        percent = 5
    }


    NOTA: La idea es que los conjuntos de evaluaciones puedan ser "dinámicos", pero que cada conjunto de evaluaciones esté
    predefinido, por ejemplo, el modelo     
        3 examenes de 30% cada uno
        2 quices de 5% cada uno
    puede ser un tipo predeterminado, y para eso se utiliza el type (digamos tipo 1)
    Actualmente, esa variable no se está utilizando en ningún lugar del código, pero la idea es llegar a usarla
    con el proposito descrito, para que exista una especie de "menú" de tipos de conjuntos de evaluaciones

     */
}
