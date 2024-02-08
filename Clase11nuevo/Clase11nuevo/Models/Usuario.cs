using System;
using System.Collections.Generic;

namespace Clase11nuevo.Models
{
    public partial class Usuario
    {
        public long Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contraseña { get; set; }
        public string? Mail { get; set; }
    }
}
