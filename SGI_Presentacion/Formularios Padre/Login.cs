using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtIngresarLgn_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "admin" && TxtPass.Text == "admin")
            {
                this.Hide();
                OpcionesAdmin opcionAdmin = new OpcionesAdmin();
                opcionAdmin.Show();
            }
        }
    }
}
