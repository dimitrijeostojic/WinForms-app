using Common;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class Broker
    {
        private DbConnection connection;

        public Broker()
        {
            try
            {
                connection = new DbConnection();
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        public void OpenConnection()
        {
            connection.OpenConnection();
        }

        public void CloseConnection()
        {
            connection.CloseConnection();
        }

        public void BeginTransaction()
        {
            connection.BeginTransaction();
        }
        public void Commit()
        {
            connection.Commit();
        }
        public void Rollback()
        {
            connection.Rollback();
        }

        public void Create(IEntity entity)
        {
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"insert into [{entity.TableName}] values ({entity.Values})";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select {entity.SelectValues} from [{entity.TableName}] {entity.JoinCondition}";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<IEntity> list = entity.GetReaderList(reader);
                cmd.Dispose();
                return list;
            }
        }

        public List<IEntity> GetAllWithWhere(IEntity entity, IEntity entity2)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select {entity2.SelectValues} from {entity2.TableName} {entity2.JoinCondition} where {entity2.Where}={entity.WhereF}";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<IEntity> list = entity2.GetReaderList(reader);
                cmd.Dispose();
                return list;
            }
        }

        public void Update(IEntity entity)
        {
            try
            {
                var query = $"update [{entity.TableName}] set {entity.UpdateValues} where {entity.WhereValues}";
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Delete(IEntity entity)
        {
            try
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = $"delete from {entity.TableName} where {entity.WhereValues}";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public List<IEntity> SearchEntities(IEntity entity, IEntity entity2, string input, string whereCondition)
        {
            SqlCommand cmd = connection.CreateCommand();

            if (entity2 != null)
            {
                cmd.CommandText = $"SELECT {entity.SelectValues} FROM [{entity.TableName}] {entity.JoinCondition} WHERE {whereCondition} LIKE '%{input}%' AND {entity.Where}={entity2.WhereF}";
            }
            else
            {
                cmd.CommandText = $"SELECT {entity.SelectValues} FROM [{entity.TableName}] {entity.JoinCondition} WHERE {whereCondition} LIKE '%{input}%'";
            }

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<IEntity> list = entity.GetReaderList(reader);
                return list;
            }
        }


        public List<IEntity> GetByID(IEntity entity, object argument)
        {
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = $"select {entity.SelectValues} from [{entity.TableName}] {entity.JoinCondition} where {entity.ID}='{argument}'";
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                List<IEntity> list = entity.GetReaderList(reader);
                cmd.Dispose();
                return list;
            }
        }
    }
}
