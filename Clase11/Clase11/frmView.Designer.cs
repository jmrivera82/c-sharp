namespace Clase11
{
    partial class frmView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvProductos = new DataGridView();
            btnCargarDatos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(55, 125);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(698, 213);
            dgvProductos.TabIndex = 0;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Location = new Point(55, 62);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(75, 23);
            btnCargarDatos.TabIndex = 1;
            btnCargarDatos.Text = "Cargar";
            btnCargarDatos.UseVisualStyleBackColor = true;
            btnCargarDatos.Click += btnCargarDatos_Click;
            // 
            // frmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCargarDatos);
            Controls.Add(dgvProductos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Formulario";
            Load += frmView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnCargarDatos;
    }
}