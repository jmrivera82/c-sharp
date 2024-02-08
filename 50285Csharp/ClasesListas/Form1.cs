using System.Collections.Generic;

namespace ClasesListas
{
    public partial class frmHola : Form
    {
        public frmHola()
        {
            InitializeComponent();
        }

        private void frmHola_Load(object sender, EventArgs e)
        {
            string[] razasdePerrosArray = new string[5];

            razasdePerrosArray[0] = "Dalmata";
            razasdePerrosArray[1] = "Alemán";
            razasdePerrosArray[2] = "Salchicha";
            razasdePerrosArray[3] = "Caniche";
            razasdePerrosArray[4] = "Pequines";

            for (int i = 0 ; i < razasdePerrosArray.Length; i++)
            {
                lstRazas.Items.Add(razasdePerrosArray[i]);
            }


            Producto[] BebidasGaseosas = {
                new Producto(1,"Coca Cola", 28, "Gaseosa"),
                new Producto(1, "Manaos", 84, "Gaseosa"),
                new Producto(1, "Pepsi", 18, "Gaseosa"),
                new Producto(1,"Fanta", 45, "Gaseosa")
                };

            Producto BebidaMasCara = new Producto();
            

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}