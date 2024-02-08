using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase8Listas
{
    public class Cliente
    {

        //constructor
        public Cliente  (long id, string nombre, string direccion, short edad)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Edad = edad;

        }


        public long ID { get; set; }    
        public string Nombre { get; set; }  
        public string Direccion { get; set; }   
        public short Edad { get; set; }

    public override bool Equals(object obj)

    {
        Cliente cliente = (Cliente)obj;
        return this.ID.Equals(cliente.ID);
    }




    }


}
