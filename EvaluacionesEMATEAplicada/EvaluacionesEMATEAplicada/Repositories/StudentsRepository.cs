using EvaluacionesEMATEAplicada.Models;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaluacionesEMATEAplicada.Repositories
{
    public class StudentsRepository : BaseRepository<StudentModel, string>
    {
        //Database table's name
        const string STUDENT = "Student";

        public StudentsRepository()
        {
            ConnectToDataBase();
        }

        //NECESITA SER PROBADO
        public override int Delete(StudentModel student)
        {
            int affectedRows = Connector.GetFactory()
                                      .Query(STUDENT)
                                      .Where("id", "=", student.id)
                                      .Delete();
            return affectedRows;
        }

        //NECESITA SER PROBADO
        public override StudentModel FindByKey(string primaryKey)
        {
            StudentModel student = Connector.GetFactory()
                                        .Query(STUDENT)
                                        .Select("*")
                                        .Where("id", "=", primaryKey)
                                        .FirstOrDefault<StudentModel>();
            return student;
        }

        public override IEnumerable<StudentModel> GetAll()
        {
            IEnumerable<StudentModel> students = Connector.GetFactory()
                                                             .Query(STUDENT)
                                                             .Select("*")
                                                             .Get<StudentModel>();
            return students;

        }

        //NECESITA SER PROBADO
        public override int Insert(StudentModel student)
        {
            int affectedRows = Connector.GetFactory()
                                      .Query(STUDENT)
                                      .Insert(student);
            return affectedRows;
        }

        //NECESITA SER PROBADO
        public override int Update(StudentModel student)
        {
            int affectedRows = Connector.GetFactory()
                                      .Query(STUDENT)
                                      .Where("id", "=", student.id)
                                      .Update(new {
                                          student.firstName,
                                          student.firstLastName,
                                          student.secondLastName

                                      });
            return affectedRows;
        }
    }
}
