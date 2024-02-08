using Clase11nuevo.Database;
using Clase11nuevo.Models;
using System.Data.SqlClient;


namespace Clase11nuevo
{
    public partial class frmView : Form
    {

        public frmView()
        {
            InitializeComponent();
        }



        public void btnCargarDatos_Click(object sender, EventArgs e)
        {

            using (CoderContext database = new CoderContext()) ;
            {

              //  List<Usuario> usuarios = database.Usuarios.ToList();

               // this.dgvListado.DataSource = usuarios;

            }

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmView_Load(object sender, EventArgs e)
        {
            var db = new CoderContext();

            var usuarios = db.Usuario
                .OrderBy(b => b.Id)
                .ToList();

            dgvListado.AutoGenerateColumns = true;
            dgvListado.DataSource = usuarios;


        }
    }
}