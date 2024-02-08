using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraEntrega50285
{
    public class Usuario
    {
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string Contraseña { get; set; }

        public string Mail { get; set; }
    }
}
