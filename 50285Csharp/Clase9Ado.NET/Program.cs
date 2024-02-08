using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Clase9Ado.NET
{
    class Program
    {
        static void Main(string[] args) 
        {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=proyecto;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                //crear comando
                SqlDataAdapter adapter = new SqlDataAdapter("Select * from usuarios", connection);
                

                    //abrir conexión
                connection.Open();
                    
                    //crea objeto con resultado vacio
                DataSet resultado = new DataSet();

                    //llena objeto con resultado
                adapter.Fill(resultado);

                connection.Close();

            }
        }
    }
}
