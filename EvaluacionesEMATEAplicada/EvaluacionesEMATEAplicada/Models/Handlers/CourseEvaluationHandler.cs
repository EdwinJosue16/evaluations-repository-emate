using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace EvaluacionesEMATEAplicada.Models.Handlers
{
    public class CourseEvaluationHandler
    {
        private readonly IConfiguration configuration;
        private string connectionString;
        private SqlConnection connection;

        public CourseEvaluationHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnectionString");
            connection = new SqlConnection(connectionString);
        }

        private DataTable CreateQueryTable(string query)
        {
            SqlCommand commandQuery = new SqlCommand(query, connection);
            SqlDataAdapter adaptadorParaTabla = new SqlDataAdapter(commandQuery);
            DataTable queryTable = new DataTable();
            connection.Open();
            adaptadorParaTabla.Fill(queryTable);
            connection.Close();
            return queryTable;
        }

        public List<StudentModel> GetStudents()
        {
            List<StudentModel> studentsInfo = new List<StudentModel>();
            string query = "SELECT id, firstName, lastName, secondLastName FROM Student ";
            DataTable tablaResultado = CreateQueryTable(query);
            foreach (DataRow row in tablaResultado.Rows)
            {
                studentsInfo.Add(
                new StudentModel
                {
                    id = Convert.ToString(row["id"]),
                    firstName = Convert.ToString(row["firstName"]),
                    firstLastName = Convert.ToString(row["lastName"]),
                    secondLastName = Convert.ToString(row["secondLastName"])
                });
            }
            return studentsInfo;
        }

        public EvaluationsSetModel EvaluationsSet1OfStudent(string studentId, string courseCode, int classNumber)
        {
            EvaluationsSetModel evaluations = new EvaluationsSetModel();
            evaluations.singleEvaluations = new List<SingleEvaluationModel>();
            string query = "SELECT examIGrade, examIIGrade, examIIIGrade, homeworkGrade " +
                           "FROM SetOfEvaluations1 " +
                           "WHERE id=@studentId" ;
            SqlCommand commandForQuery = new SqlCommand(query, connection);
            commandForQuery.Parameters.AddWithValue("@studentId", studentId);
            connection.Open();
            SqlDataReader dataReader = commandForQuery.ExecuteReader();
            dataReader.Read();

            evaluations.singleEvaluations.Add(
                    new SingleEvaluationModel
                    {
                        type = "Parcial I",
                        evaluationGrade = Convert.ToDouble(dataReader["examIGrade"]),
                        percent = 23.33
                    });
            evaluations.singleEvaluations.Add(
                    new SingleEvaluationModel
                    {
                        type = "Parcial II",
                        evaluationGrade = Convert.ToDouble(dataReader["examIIGrade"]),
                        percent = 23.33
                    });
            evaluations.singleEvaluations.Add(
                    new SingleEvaluationModel
                    {
                        type = "Parcial III",
                        evaluationGrade = Convert.ToDouble(dataReader["examIIIGrade"]),
                        percent = 23.33
                    });
            evaluations.singleEvaluations.Add(
                    new SingleEvaluationModel
                    {
                        type = "Tareas",
                        evaluationGrade = Convert.ToDouble(dataReader["homeworkGrade"]),
                        percent = 30
                    });
            connection.Close();
            evaluations.courseCode = courseCode;
            evaluations.courseGroup = classNumber;
            return evaluations;
        }
    }
}
