using System.Data.SqlClient;

namespace Data
{
    public class GroupDataAccess : DbDataAccess
    {
        public override void CreateTable()
        {
            var createSqlScript = $"Create table [Group] (id int primary key identity, [name]  nvarchar(50) check([name] <>N'') unique not null);";
           
            using (var command = new SqlCommand(createSqlScript, sqlConnection))
            {
                  command.ExecuteNonQuery();
            }
        }
    }
}
