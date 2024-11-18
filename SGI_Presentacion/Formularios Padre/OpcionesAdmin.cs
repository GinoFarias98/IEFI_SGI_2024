using SGI_Entidades;
using SGI_Presentacion.Formularios_Hijo;
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
    public partial class OpcionesAdmin : Form
    {
        public OpcionesAdmin()
        {
            InitializeComponent();  
        }

        private void AbrirForm<T>() where T : Form, new()
        {
            var NuevoForm = Application.OpenForms.OfType<T>().FirstOrDefault();
            if (NuevoForm == null)
            {
                var formulario = new T { MdiParent = this }; 
                formulario.Show();
            }
            else
            {
                NuevoForm.BringToFront();
            }
        }

        private void TsTipoDocumento_Click(object sender, EventArgs e)
        {
            AbrirForm<TipoDocumentoABM>();
           
        }

        private void TsTipoRol_Click(object sender, EventArgs e)
        {
            AbrirForm<TipoRolABM>();
        }

        private void TsTipoObjeto_Click(object sender, EventArgs e)
        {
            AbrirForm<TipoObjetoABM>();
        }

        private void TsObjeto_Click(object sender, EventArgs e)
        {
            AbrirForm<ObjetoABM>();
        }

        private void TsPersona_Click(object sender, EventArgs e)
        {
            AbrirForm<PersonaABM>();
        }

        private void TsUsuario_Click(object sender, EventArgs e)
        {
            AbrirForm<UsuarioABM>();
        }
    }
}
