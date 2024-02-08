using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Herencia
{
    public class Empleado : Persona
    {
        protected string legajo;
        public Empleado(string legajo, long dni, string nombre, string domicilioParticular) : base (dni,nombre, domicilioParticular ) //base hace referencia a la clase padre
        {
            this.legajo = legajo;
        
        }
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Legajo:" + this.legajo);
        }



    }
}
