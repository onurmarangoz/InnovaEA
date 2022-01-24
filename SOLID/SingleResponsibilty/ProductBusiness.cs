using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilty
{
    public class ProductBusiness
    {
        public int AddProduct(string name, decimal price)
        {
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vakifDb;Integrated Security=True";
            string commandText = "Insert into Products (Name, Price) values (@Name,@Price) ";

            Dictionary<string, object> args = new Dictionary<string, object>();


            args.Add("@Name", name);
            args.Add("@Price", price);

            var helper = new SqlHelper(connectionString);
            int affectedRows = helper.ExecuteCommand(commandText, args);

            return affectedRows;

        }
    }
}
