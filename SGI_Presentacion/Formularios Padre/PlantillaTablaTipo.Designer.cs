namespace SGI_Presentacion.Formularios_Padre
{
    partial class PlantillaTablaTipo
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
            this.CbOpciones = new System.Windows.Forms.ComboBox();
            this.BtAceptarOpcion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvPlantillaTipo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlantillaTipo)).BeginInit();
            this.SuspendLayout();
            // 
            // CbOpciones
            // 
            this.CbOpciones.FormattingEnabled = true;
            this.CbOpciones.Location = new System.Drawing.Point(57, 54);
            this.CbOpciones.Name = "CbOpciones";
            this.CbOpciones.Size = new System.Drawing.Size(121, 21);
            this.CbOpciones.TabIndex = 1;
            this.CbOpciones.Text = "Opciones";
            // 
            // BtAceptarOpcion
            // 
            this.BtAceptarOpcion.Location = new System.Drawing.Point(278, 52);
            this.BtAceptarOpcion.Name = "BtAceptarOpcion";
            this.BtAceptarOpcion.Size = new System.Drawing.Size(100, 23);
            this.BtAceptarOpcion.TabIndex = 2;
            this.BtAceptarOpcion.Text = "Aceptar Opcion";
            this.BtAceptarOpcion.UseVisualStyleBackColor = true;
            this.BtAceptarOpcion.Click += new System.EventHandler(this.BtAceptarOpcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(128, 103);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(167, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(128, 129);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(167, 20);
            this.TxtCodigo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvPlantillaTipo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(385, 245);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // DgvPlantillaTipo
            // 
            this.DgvPlantillaTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlantillaTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPlantillaTipo.Location = new System.Drawing.Point(10, 23);
            this.DgvPlantillaTipo.Name = "DgvPlantillaTipo";
            this.DgvPlantillaTipo.Size = new System.Drawing.Size(365, 212);
            this.DgvPlantillaTipo.TabIndex = 0;
            // 
            // PlantillaTablaTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtAceptarOpcion);
            this.Controls.Add(this.CbOpciones);
            this.Name = "PlantillaTablaTipo";
            this.Text = "PlantillaTablaTipo";
            this.Controls.SetChildIndex(this.CbOpciones, 0);
            this.Controls.SetChildIndex(this.BtAceptarOpcion, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlantillaTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbOpciones;
        private System.Windows.Forms.Button BtAceptarOpcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvPlantillaTipo;
    }
}