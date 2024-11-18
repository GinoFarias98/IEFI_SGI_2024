namespace SGI_Presentacion.Formularios_Hijo
{
    partial class TipoObjetoABM
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
            this.BtAceptarOpciones = new System.Windows.Forms.Button();
            this.CbTObjeto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvTipoObjeto = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipoObjeto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtAceptarOpciones
            // 
            this.BtAceptarOpciones.Location = new System.Drawing.Point(268, 70);
            this.BtAceptarOpciones.Name = "BtAceptarOpciones";
            this.BtAceptarOpciones.Size = new System.Drawing.Size(110, 23);
            this.BtAceptarOpciones.TabIndex = 1;
            this.BtAceptarOpciones.Text = "Aceptar Opcion";
            this.BtAceptarOpciones.UseVisualStyleBackColor = true;
            this.BtAceptarOpciones.Click += new System.EventHandler(this.BtAceptarOpciones_Click);
            // 
            // CbTObjeto
            // 
            this.CbTObjeto.FormattingEnabled = true;
            this.CbTObjeto.Location = new System.Drawing.Point(37, 72);
            this.CbTObjeto.Name = "CbTObjeto";
            this.CbTObjeto.Size = new System.Drawing.Size(114, 21);
            this.CbTObjeto.TabIndex = 2;
            this.CbTObjeto.Text = "Opciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(84, 116);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(159, 20);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(84, 142);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(159, 20);
            this.TxtCodigo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Codigo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DgvTipoObjeto);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(800, 245);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // DgvTipoObjeto
            // 
            this.DgvTipoObjeto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTipoObjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvTipoObjeto.Location = new System.Drawing.Point(10, 23);
            this.DgvTipoObjeto.Name = "DgvTipoObjeto";
            this.DgvTipoObjeto.Size = new System.Drawing.Size(780, 212);
            this.DgvTipoObjeto.TabIndex = 0;
            // 
            // TipoObjetoABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbTObjeto);
            this.Controls.Add(this.BtAceptarOpciones);
            this.Name = "TipoObjetoABM";
            this.Text = "Gestion de Tipo de Objeto";
            this.Controls.SetChildIndex(this.BtAceptarOpciones, 0);
            this.Controls.SetChildIndex(this.CbTObjeto, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TxtNombre, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.TxtCodigo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTipoObjeto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtAceptarOpciones;
        private System.Windows.Forms.ComboBox CbTObjeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvTipoObjeto;
    }
}