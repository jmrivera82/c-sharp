using System;
using System.Collections.Generic;

namespace Clase11nuevo.Models
{
    public partial class Productosvendido
    {
        public long Id { get; set; }
        public long? Idproducto { get; set; }
        public long? Stock { get; set; }
        public long? Idventa { get; set; }
    }
}
