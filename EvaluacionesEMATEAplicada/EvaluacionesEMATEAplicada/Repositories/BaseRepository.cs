using System.Collections.Generic;

namespace EvaluacionesEMATEAplicada.Repositories
{
    public abstract class BaseRepository <M,K>
    {
        protected DatabaseConnector Connector;

        protected void ConnectToDataBase()
        {
            Connector = new DatabaseConnector();
        }

        public abstract int Insert(M model);
        public abstract int Update(M model);
        public abstract int Delete(M model);
        public abstract M FindByKey(K primaryKey);
        public abstract IEnumerable<M> GetAll();

    }
}
