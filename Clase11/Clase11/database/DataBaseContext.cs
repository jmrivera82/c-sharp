using Clase11.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clase11.database
{
    public class DataBaseContext : DbContext

    {

        public DbSet<Producto> Productos { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(connectionString: "Server=localhost\\SQLEXPRESS;Database = coder29012024; Trusted_Connection = True;");




        }
    }
}
