using EvaluacionesEMATEAplicada.Models;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EvaluacionesEMATEAplicada.Repositories
{
    public class EvaluationsRepository : BaseRepository<EvaluationsSetModel, int> //el pk es el tipo de conjunto de evaluacion
    {

        public EvaluationsRepository()
        {
            ConnectToDataBase();
        }

        //ESTE METODO ES DUMMIE Y FUNCIONA PARA PROBAR EL DESPLIEGUE DE LA INFERFAZ (ModifyEvaluationOf)
        public EvaluationsSetModel EvaluationsFilterBy(string studentId, string courseCode, int classNumber)
        {
            //TODO
            throw new NotImplementedException();
        }


        public override int Delete(EvaluationsSetModel model)
        {
            //TODO
            throw new NotImplementedException();
        }

        public override EvaluationsSetModel FindByKey(int primaryKey)
        {
            //TODO
            throw new NotImplementedException();
        }

        public override IEnumerable<EvaluationsSetModel> GetAll()
        {
            //TODO
            throw new NotImplementedException();
        }

        public override int Insert(EvaluationsSetModel model)
        {
            //TODO
            throw new NotImplementedException();
        }

        public override int Update(EvaluationsSetModel model)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
