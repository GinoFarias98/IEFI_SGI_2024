namespace SGI_Presentacion
{
    partial class Login
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtIngresarLgn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtRegistrarLgn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(84, 51);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(179, 20);
            this.TxtUser.TabIndex = 0;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(84, 110);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(179, 20);
            this.TxtPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // BtIngresarLgn
            // 
            this.BtIngresarLgn.Location = new System.Drawing.Point(130, 167);
            this.BtIngresarLgn.Name = "BtIngresarLgn";
            this.BtIngresarLgn.Size = new System.Drawing.Size(75, 23);
            this.BtIngresarLgn.TabIndex = 4;
            this.BtIngresarLgn.Text = "Ingresar";
            this.BtIngresarLgn.UseVisualStyleBackColor = true;
            this.BtIngresarLgn.Click += new System.EventHandler(this.BtIngresarLgn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "¿Todavia no tiene un usuario creado?\r\nRegistrese";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtRegistrarLgn
            // 
            this.BtRegistrarLgn.Location = new System.Drawing.Point(130, 255);
            this.BtRegistrarLgn.Name = "BtRegistrarLgn";
            this.BtRegistrarLgn.Size = new System.Drawing.Size(75, 23);
            this.BtRegistrarLgn.TabIndex = 7;
            this.BtRegistrarLgn.Text = "Registrarme";
            this.BtRegistrarLgn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.BtRegistrarLgn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtIngresarLgn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtIngresarLgn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtRegistrarLgn;
    }
}