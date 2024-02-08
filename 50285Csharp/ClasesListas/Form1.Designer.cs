namespace ClasesListas
{
    partial class frmHola
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
            lblHola = new Label();
            lstRazas = new ListBox();
            lblRazas = new Label();
            SuspendLayout();
            // 
            // lblHola
            // 
            lblHola.AutoSize = true;
            lblHola.Location = new Point(100, 24);
            lblHola.Name = "lblHola";
            lblHola.Size = new Size(70, 15);
            lblHola.TabIndex = 0;
            lblHola.Text = "Hello World";
            // 
            // lstRazas
            // 
            lstRazas.FormattingEnabled = true;
            lstRazas.ItemHeight = 15;
            lstRazas.Location = new Point(327, 120);
            lstRazas.Name = "lstRazas";
            lstRazas.Size = new Size(120, 94);
            lstRazas.TabIndex = 1;
            lstRazas.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblRazas
            // 
            lblRazas.AutoSize = true;
            lblRazas.Location = new Point(327, 85);
            lblRazas.Name = "lblRazas";
            lblRazas.Size = new Size(88, 15);
            lblRazas.TabIndex = 2;
            lblRazas.Text = "Razas de Perros";
            // 
            // frmHola
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRazas);
            Controls.Add(lstRazas);
            Controls.Add(lblHola);
            Name = "frmHola";
            Text = "Form1";
            Load += frmHola_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHola;
        private ListBox lstRazas;
        private Label lblRazas;
    }
}