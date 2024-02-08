namespace Clase11nuevo
{
    partial class frmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCargar = new Button();
            dgvListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(34, 30);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(107, 42);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(34, 98);
            dgvListado.Name = "dgvListado";
            dgvListado.RowTemplate.Height = 25;
            dgvListado.Size = new Size(712, 216);
            dgvListado.TabIndex = 1;
            // 
            // frmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListado);
            Controls.Add(btnCargar);
            Name = "frmView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private DataGridView dgvListado;
    }
}