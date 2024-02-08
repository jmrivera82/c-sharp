using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8Listas
{
    public class Matriz
    {

        private int[,] _matriz;
        private const int DIMENSION_FILA = 0;
        private const int DIMENSION_COLUMNA = 1;


        public Matriz()
        {
            _matriz = new int[2, 3]; //matriz por defecto
        }

        public Matriz(int filas, int columnas)
        {
            if (columnas > 0 && filas > 0)
                _matriz = new int[filas, columnas];
            else
                new Matriz();
        }

        public void Ingresar()
        {
            for (int filas = 0; filas < _matriz.GetLength(DIMENSION_FILA); filas++)
            {

                for (int columnas = 0; columnas < _matriz.GetLength(DIMENSION_COLUMNA);columnas++)
                {
                    Console.WriteLine("Ingrese valor entero en la posición [" + (filas + 1) + "," + (columnas + 1) + "] :");
                    string linea;
                    linea = Console.ReadLine(); 

                    try
                    {
                        _matriz[filas,columnas] = int.Parse(linea);
                    }
                    catch (Exception ex)
                    {
                        columnas = columnas - 1;
                        Console.WriteLine("ERROR CRITICO", ex.Message);
                    }

                }


            }
        }

        public void Imprimir()
        {

            for (int filas = 0; filas < _matriz.GetLength(DIMENSION_FILA); filas++)
            {

                for (int columnas = 0; columnas < _matriz.GetLength(DIMENSION_COLUMNA); columnas++)
                {
                    Console.WriteLine(_matriz[filas, columnas] + " ");

                }

                Console.WriteLine();

            }

        }

    }
}
