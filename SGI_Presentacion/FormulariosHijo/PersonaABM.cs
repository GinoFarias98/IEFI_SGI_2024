using SGI_Entidades;
using SGI_Negociacion;
using SGI_Presentacion.Formularios_Padre;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGI_Presentacion.Formularios_Hijo
{
    public partial class PersonaABM : PlantillaEntDependientes
    {
        public PersonaABM()
        {
            InitializeComponent();

            PlantillaEntDependientes plantillaDependiente = new PlantillaEntDependientes();
            this.Size = plantillaDependiente.Size;
            this.StartPosition = FormStartPosition.CenterParent;
            this.lblTitulo.Text = this.Text;

            cbOpciones.SelectedIndexChanged += ModifOAlta_SelectedIndexChanged;

            var Textos = new Dictionary<string, string>
            {
                {"lblProp1", "Nombre" },
                {"lblProp2", "Apellido" },
                {"lblProp3", "Numero Documento" },
                {"lblProp4", "Telefono" },
                {"lblProp5", "Numero Box" },
                {"lblCb1", "Seleccione un documento" }

            };

            ActualizarTextos(Textos);

            lblProp3.Tag = "NumDoc";

            lblProp6.Visible = false;
            lblProp7.Visible = false;
            lblProp8.Visible = false;
            lblCb2.Visible = false;

            txtProp6.Visible = false;
            txtProp7.Visible = false;
            txtProp8.Visible = false;
            cbx2.Visible = false;
        }



        private void ModifOAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ( cbOpciones.SelectedItem != null && cbOpciones.SelectedItem.ToString() == "Alta"
                || cbOpciones.SelectedItem != null && cbOpciones.SelectedItem.ToString() == "Modificar")
            {
                CargarCodigoEnCB<TipoDocumento>(new NegociadorGenerico<TipoDocumento>());
            } 
        }


        protected override object CrearEntidad()
        {
            return new Persona
            {
                Nombre = txtProp1.Text,
                Apellido = txtProp2.Text,
                NumDoc = txtProp3.Text,
                Telefono = txtProp4.Text,
                Estado = true,
                NumBox = txtProp5.Text,
                TipoDocumento_Id = Convert.ToInt32(cbx1.SelectedValue),
            };
        }

        protected override void MostrarEntidades()
        {
            NegociadorGenerico<Persona> NegociadorPersona = new NegociadorGenerico<Persona>();
            var Tabla = NegociadorPersona.ActualizarDs(lblProp3.Tag.ToString(), txtProp3.Text);
            dgvPlantillaTipo.DataSource = Tabla;
        }
    }
}
