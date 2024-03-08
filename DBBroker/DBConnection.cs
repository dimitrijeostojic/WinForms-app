using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBroker
{
    public class DbConnection
    {
        private SqlConnection conn;
        private SqlTransaction tran;

        public DbConnection()
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["projekatSoftveri"].ConnectionString);
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
        }

        public void OpenConnection()
        {
            conn?.Open();
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public void BeginTransaction()
        {
            tran = conn.BeginTransaction();
        }
        public void Commit()
        {
            tran?.Commit();
        }
        public void Rollback()
        {
            tran.Rollback();
        }
        public SqlCommand CreateCommand()
        {
            return new SqlCommand("", conn, tran);
        }
    }
}
