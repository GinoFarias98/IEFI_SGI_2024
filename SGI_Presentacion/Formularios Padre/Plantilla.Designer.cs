namespace SGI_Presentacion.Formularios_Hijo
{
    partial class Plantilla
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
            this.panelPlantilla = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtMinimizar = new System.Windows.Forms.Button();
            this.BtCerrar = new System.Windows.Forms.Button();
            this.panelPlantilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPlantilla
            // 
            this.panelPlantilla.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelPlantilla.Controls.Add(this.LblTitulo);
            this.panelPlantilla.Controls.Add(this.BtMinimizar);
            this.panelPlantilla.Controls.Add(this.BtCerrar);
            this.panelPlantilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlantilla.Location = new System.Drawing.Point(0, 0);
            this.panelPlantilla.Name = "panelPlantilla";
            this.panelPlantilla.Size = new System.Drawing.Size(381, 37);
            this.panelPlantilla.TabIndex = 0;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.Color.MintCream;
            this.LblTitulo.Location = new System.Drawing.Point(12, 11);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(38, 13);
            this.LblTitulo.TabIndex = 1;
            this.LblTitulo.Text = "label1";
            // 
            // BtMinimizar
            // 
            this.BtMinimizar.Location = new System.Drawing.Point(314, 6);
            this.BtMinimizar.Name = "BtMinimizar";
            this.BtMinimizar.Size = new System.Drawing.Size(29, 23);
            this.BtMinimizar.TabIndex = 2;
            this.BtMinimizar.Text = "_";
            this.BtMinimizar.UseVisualStyleBackColor = true;
            this.BtMinimizar.Click += new System.EventHandler(this.BtMinimizar_Click);
            // 
            // BtCerrar
            // 
            this.BtCerrar.Location = new System.Drawing.Point(349, 6);
            this.BtCerrar.Name = "BtCerrar";
            this.BtCerrar.Size = new System.Drawing.Size(29, 23);
            this.BtCerrar.TabIndex = 3;
            this.BtCerrar.Text = "X";
            this.BtCerrar.UseVisualStyleBackColor = true;
            this.BtCerrar.Click += new System.EventHandler(this.BtCerrar_Click);
            // 
            // Plantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 453);
            this.Controls.Add(this.panelPlantilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Plantilla";
            this.Text = "Plantilla";
            this.panelPlantilla.ResumeLayout(false);
            this.panelPlantilla.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPlantilla;
        private System.Windows.Forms.Button BtMinimizar;
        private System.Windows.Forms.Button BtCerrar;
        private System.Windows.Forms.Label LblTitulo;
    }
}