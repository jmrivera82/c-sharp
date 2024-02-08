using Clase11.database;
using Clase11.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase11
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            using (DataBaseContext context = new DataBaseContext())
            {

                List<Producto> productos = context.Productos.ToList();

                this.dgvProductos.DataSource = productos;



            }
        }
    }
}
