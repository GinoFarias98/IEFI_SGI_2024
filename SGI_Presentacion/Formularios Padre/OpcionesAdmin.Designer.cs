namespace SGI_Presentacion
{
    partial class OpcionesAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpcionesAdmin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.TsTipoDocumento = new System.Windows.Forms.ToolStripMenuItem();
            this.TsTipoRol = new System.Windows.Forms.ToolStripMenuItem();
            this.TsTipoObjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.TsObjeto = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPersona = new System.Windows.Forms.ToolStripMenuItem();
            this.TsUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsTipoDocumento,
            this.TsTipoRol,
            this.TsTipoObjeto,
            this.TsObjeto,
            this.TsPersona,
            this.TsUsuario,
            this.toolStripSeparator1});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Opciones";
            // 
            // TsTipoDocumento
            // 
            this.TsTipoDocumento.Name = "TsTipoDocumento";
            this.TsTipoDocumento.Size = new System.Drawing.Size(163, 22);
            this.TsTipoDocumento.Text = "Tipo Documento";
            this.TsTipoDocumento.Click += new System.EventHandler(this.TsTipoDocumento_Click);
            // 
            // TsTipoRol
            // 
            this.TsTipoRol.Name = "TsTipoRol";
            this.TsTipoRol.Size = new System.Drawing.Size(163, 22);
            this.TsTipoRol.Text = "Tipo Rol";
            this.TsTipoRol.Click += new System.EventHandler(this.TsTipoRol_Click);
            // 
            // TsTipoObjeto
            // 
            this.TsTipoObjeto.Name = "TsTipoObjeto";
            this.TsTipoObjeto.Size = new System.Drawing.Size(163, 22);
            this.TsTipoObjeto.Text = "Tipo Objeto";
            this.TsTipoObjeto.Click += new System.EventHandler(this.TsTipoObjeto_Click);
            // 
            // TsObjeto
            // 
            this.TsObjeto.Name = "TsObjeto";
            this.TsObjeto.Size = new System.Drawing.Size(163, 22);
            this.TsObjeto.Text = "Objeto";
            this.TsObjeto.Click += new System.EventHandler(this.TsObjeto_Click);
            // 
            // TsPersona
            // 
            this.TsPersona.Name = "TsPersona";
            this.TsPersona.Size = new System.Drawing.Size(163, 22);
            this.TsPersona.Text = "Persona";
            this.TsPersona.Click += new System.EventHandler(this.TsPersona_Click);
            // 
            // TsUsuario
            // 
            this.TsUsuario.Name = "TsUsuario";
            this.TsUsuario.Size = new System.Drawing.Size(163, 22);
            this.TsUsuario.Text = "Usuario";
            this.TsUsuario.Click += new System.EventHandler(this.TsUsuario_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // OpcionesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 440);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "OpcionesAdmin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "OpcionesAdmin";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem TsTipoDocumento;
        private System.Windows.Forms.ToolStripMenuItem TsTipoRol;
        private System.Windows.Forms.ToolStripMenuItem TsTipoObjeto;
        private System.Windows.Forms.ToolStripMenuItem TsObjeto;
        private System.Windows.Forms.ToolStripMenuItem TsPersona;
        private System.Windows.Forms.ToolStripMenuItem TsUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}