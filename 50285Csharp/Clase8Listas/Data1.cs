using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase8Listas
{
    public partial class Data1 : Form
    {
        public Data1()
        {
            InitializeComponent();
        }

        ListaMayores listaMayores;


        private void CargaMayores()
        {
            dgvNombres.DataSource = null;
            dgvNombres.AutoGenerateColumns = true;
            dgvNombres.DataSource = listaMayores.GetListaClientes();
        }

        private void Data1_Load(object sender, EventArgs e)
        {
            listaMayores = new ListaMayores();

            Cliente[] clientes = {
                new Cliente(1111,"JJJJJJ PPPP", "Calle 1", 55),
                new Cliente(3333,"AAAABB CCCC", "Calle 2", 12),
                new Cliente(4444,"EEEEEE FFFF ", "Calle 3", 33),
                new Cliente(5555,"SSSSSS RRRR", "Calle 4", 44),
                new Cliente(6666,"UUUUUU ZZZZ", "Calle 5", 99)
                };

            listaMayores.InsertarEnLista(clientes);

            CargaMayores();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente clienteAModificar = new Cliente(4444, "EEEEEE FFFF ", "Calle 3", 33);
            Cliente clienteNuevo = new Cliente(12345, "José Rivera", "Calle 3", 33);

            listaMayores.Modificar(clienteAModificar, clienteNuevo);

            CargaMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteABorrar = new Cliente(6666, "UUUUUU ZZZZ", "Calle 5", 99);
            listaMayores.Borrar(clienteABorrar);

            CargaMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            listaMayores.Ordenar();
            CargaMayores();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvNombres.DataSource = null;
            dgvNombres.Refresh();
            listaMayores.LimpiarLista();
        }
    }
}
