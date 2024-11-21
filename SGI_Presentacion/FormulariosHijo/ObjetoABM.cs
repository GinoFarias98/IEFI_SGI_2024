using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGI_Entidades;
using SGI_Entidades.Entidades;
using SGI_Negociacion;
using SGI_Presentacion.Formularios_Hijo;
using SGI_Presentacion.Formularios_Padre;


namespace SGI_Presentacion.Formularios_Hijo
{
    public partial class ObjetoABM : PlantillaEntDependientes
    {

        public ObjetoABM()
        {
            InitializeComponent();

            PlantillaEntDependientes plantillaEntDependientes = new PlantillaEntDependientes();

            this.Size = plantillaEntDependientes.Size;

            this.StartPosition = FormStartPosition.CenterParent;

            this.lblTitulo.Text = this.Text;

            cbOpciones.SelectedIndexChanged += ModifOAlta_SelectedIndexChanged;

            var Textos = new Dictionary<string, string>
            {
                {"lblProp1", "Codigo" },
                {"lblProp2", "Nombre" },
                {"lblProp3", "Numero de Serie" },
                {"lblProp4", "Descripcion" },
                {"lblProp5", "Marca" },
                {"lblProp6", "Modelo" },
                {"lblCb1", "Seleccione un Tipo de Objeto" }

            };

            ActualizarTextos(Textos);

            lblProp3.Tag = "NumeroSerie";

            lblProp7.Visible = false;
            lblProp8.Visible = false;
            lblCb2.Visible = false;

            txtProp7.Visible = false;
            txtProp8.Visible = false;
            cbx2.Visible = false;

        }

        private void ModifOAlta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpciones.SelectedItem != null && cbOpciones.SelectedItem.ToString() == "Alta"
                || cbOpciones.SelectedItem != null && cbOpciones.SelectedItem.ToString() == "Modificar")
            {
                CargarCodigoEnCB<TipoObjeto>(new NegociadorGenerico<TipoObjeto>());
            }
        }


        protected override object CrearEntidad()
        {
            return new Objeto
            {
                Codigo = txtProp1.Text,
                Nombre = txtProp2.Text,
                NumeroSerie = txtProp3.Text,
                Descripcion = txtProp4.Text,
                Marca = txtProp5.Text,
                Modelo = txtProp6.Text,
                TipoObjeto_Id = Convert.ToInt32(cbx1.SelectedValue),
            };
        }

        protected override void MostrarEntidades()
        {
            NegociadorGenerico<Objeto> NegociadorPersona = new NegociadorGenerico<Objeto>();
            var Tabla = NegociadorPersona.ActualizarDs(lblProp3.Tag.ToString(), txtProp3.Text);
            dgvPlantillaTipo.DataSource = Tabla;
        }

    }
}
