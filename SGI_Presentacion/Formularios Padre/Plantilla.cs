using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_Presentacion.Formularios_Hijo
{
    public partial class Plantilla : Form  
    {
        public Plantilla()
        {
            InitializeComponent();

            panelPlantilla.MouseDown += MoverPanel;

        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MoverPanel(object sender, MouseEventArgs e)
        {
            

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xF012, 0);
            }

            if (this.Top < 0)
            {
                this.Top = 0; // Evitar que el formulario suba más allá de la altura del ToolStrip
            }

            if (this.Bottom > this.MdiParent.ClientSize.Height)
            {
                this.Top = this.MdiParent.ClientSize.Height - this.Height;
            }

            if (this.Left < 0)
            {
                this.Left = 0;
            }

            if (this.Right > this.MdiParent.ClientSize.Width)
            {
                this.Left = this.MdiParent.ClientSize.Width - this.Width;
            }

        }

        // Métodos para permitir mover el formulario
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // ReleaseCapture: Libera la captura del mouse para que otros controles o la ventana puedan recibir eventos
        //SendMessage:  Envía un mensaje para iniciar el movimiento de la ventana

        protected Label lblTitulo => LblTitulo;

    }
}
