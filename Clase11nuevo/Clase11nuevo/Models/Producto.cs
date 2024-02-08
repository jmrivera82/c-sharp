using System;
using System.Collections.Generic;

namespace Clase11nuevo.Models
{
    public partial class Producto
    {
        public long Id { get; set; }
        public string? Descripcion { get; set; }
        public double? Costo { get; set; }
        public double? Precioventa { get; set; }
        public long? Stock { get; set; }
        public int? Idusuario { get; set; }
    }
}
