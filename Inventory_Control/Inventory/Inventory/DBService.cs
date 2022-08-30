using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Inventory
{
    internal class DBService
    {
        string path = "Data Source= .;InitialCatalog= student;Intergrated security=false;";
        SqlConnection _connection;
        public DBService()
        {
            try
            {
                _connection = new SqlConnection(path);
                _connection.Open();
               

            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
