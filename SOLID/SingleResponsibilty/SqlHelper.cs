using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
   
    public class SqlHelper
    {
        SqlConnection sqlConnection = null;
        public SqlHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteCommand(string commandText, Dictionary<string,object> parameters)
        {
            SqlCommand sqlCommand = CreateCommand(commandText, parameters);
            sqlCommand.Connection.Open();
            int affectedRows = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return affectedRows;
        }

      

        private SqlCommand CreateCommand(string commandText, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = commandText;
            AddParametersToCommand(sqlCommand, parameters);
            return sqlCommand;
        }


      
        private void AddParametersToCommand(SqlCommand sqlCommand, Dictionary<string, object> parameters)
        {
           
            foreach (var parameter in parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Key,parameter.Value)
            }
        }
    }
}
