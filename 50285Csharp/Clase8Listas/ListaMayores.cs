using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase8Listas
{
    public class ListaMayores
    {

        private List<Cliente> _clientesMayores;

        public ListaMayores()

        {
            _clientesMayores = new List<Cliente>();
        }

        public List <Cliente> GetListaClientes()

        { return _clientesMayores; }    

























        public void InsertarEnLista(Cliente[] clientes)
        {
            for (int i = 0; i < clientes.Length;i++)
            {
                _clientesMayores.Add(new Cliente(clientes[i].ID,
                    clientes[i].Nombre,
                    clientes[i].Direccion,
                    clientes[i].Edad));
             }
        }

        public bool Borrar(Cliente cliente)

        {

            if (!_clientesMayores.Contains(cliente)) return false;

            return _clientesMayores.Remove(cliente);

        }

        public int Buscar(Cliente cliente)

        {

            return _clientesMayores.IndexOf(cliente);

        }



        public bool Modificar(Cliente actual, Cliente nuevo)

        {

            int posicionClienteActual = Buscar(actual);



            if (posicionClienteActual < 0) return false;



            _clientesMayores[posicionClienteActual] = nuevo;

            return true;

        }



        public void LimpiarLista()

        {

            _clientesMayores.Clear();

        }

        public int CompararClientes(Cliente cliente1, Cliente cliente2)
        {
            return cliente1.ID.CompareTo(cliente2.ID);  
        }

        public void Ordenar()
        {
            _clientesMayores.Sort(CompararClientes);

        }



    }
}
