using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Herencia
{
    public class Circulo : Figuras, I3DmedidasCalculable
    {
        double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * this.radio;
        }

        public double Volumen()
        {
            throw new NotImplementedException();
        }
    }
}
