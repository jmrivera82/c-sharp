using Clase6Herencia;
using System;

class Program
{
    static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("A2323", 121221, "Hugo", "Calle 123");

        Estudiante estudiante1 = new Estudiante("Backend", 4555, "Jose Rivera", "Fresia 385");

        Persona persona1 = empleado1;

        //IMPLEMENTACIÓN

        empleado1.MostrarDatos();
        persona1.MostrarDatos();
        estudiante1.MostrarDatos();
        Persona.TelefonoEmergencia();



        Cubo cubo = new(1);
        Rectangulo rectangulo = new (2, 2);
        Circulo circulo = new(2);

        Console.WriteLine("Volumen Cubo: " + cubo.Volumen()+
                           "\nPerimetro rectangulo: " + rectangulo.Perimetro() 
                           + "\nArea circulo" + circulo.Area() );




        Console.WriteLine();
    }
}
