using Clase10Ado.database;
using Clase10Ado.modelo;

namespace Clase10Ado
{
    internal class Program
    {

        static void Main(string[] args)
        {

            GestorDeBaseDeDatos db = new GestorDeBaseDeDatos();

            try
            {
                //LEER USUARIO

                //Usuarios usuarioObtenido = db.ObtenerUsuarioPorId(Id: 1);
                //Console.WriteLine(usuarioObtenido.ToString());


                //AGREGAR USUARIO

                //Usuarios usuarioNuevo = new Usuarios(nombre: "Juan", apellido: "JJJ", nombreUsuario: "JuanP", clave: "12345p", mail: "juan@mail.com");

                //if (db.AgregarUsuario(usuarioNuevo))
                //{
                //    Console.WriteLine(value: "Usuario agregado");
                //}

                //ELIMINAR USUARIO

                //if (db.BorrarUsuarioPorId(id: 2))
                //{
                //    Console.WriteLine(value: "Usuario eliminado");
                //}

                //ACTUALIZAR USUARIO

                Usuarios usuarioAActualizar = new Usuarios(nombre: "Pepito", apellido: "Rivera", nombreUsuario: "pepito", clave: "1111", mail: "pepito@mail.com");

                if (db.ActualizarUsuarioPorId(id: 3,usuarioAActualizar))
                {
                    Console.WriteLine(value: "Usuario actualizado");
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            Console.WriteLine(value: "Salida del programa");



        }







    }







}
