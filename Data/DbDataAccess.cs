using System;
using System.Data.SqlClient;

namespace Data
{
    public abstract class DbDataAccess : IDisposable
    {
        protected readonly SqlConnection sqlConnection;
        public DbDataAccess()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Server=DESKTOP-H5GCVAL; Database=ConnectedLevelLesson; Trusted_Connection=true;";
            sqlConnection.Open();
        }

        public void Dispose()
        {
            sqlConnection.Close();
        }
        public abstract void CreateTable();
    }
}
