using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase8Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matriz ejemploMatriz = new Matriz(4, 3);
            ejemploMatriz.Ingresar();
            ejemploMatriz.Imprimir();
        }
    }
}
