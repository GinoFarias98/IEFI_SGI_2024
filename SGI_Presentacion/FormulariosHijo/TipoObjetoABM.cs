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
    public partial class TipoObjetoABM : PlantillaTablaTipo
    {
        public TipoObjetoABM()
        {
            InitializeComponent();

            Plantilla plantilla = new Plantilla();

            this.Size = plantilla.Size;

            this.StartPosition = FormStartPosition.CenterParent;

            this.lblTitulo.Text = this.Text;

           cbOpciones.SelectedIndexChanged += Modif_SelectedIndexChanged;

        }


        private void Modif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpciones.SelectedItem != null && cbOpciones.SelectedItem.ToString() == "Modificar")
            {
                cbCodigosModif.Visible = true;
                lblCodModif.Visible = true;

                CargarCodigoEnCB<TipoObjeto>(new NegociadorGenerico<TipoObjeto>());
            }
            else
            {
                cbCodigosModif.Visible = false;
                lblCodModif.Visible = false;
            }
            //this.Refresh();
        }

        protected override void ConfigComboBox()
        {
            base.ConfigComboBox();
        }

        protected override object CrearEntidad()
        {
            return new TipoObjeto
            {
                Nombre = txtNombre.Text,
                Codigo = txtCodigo.Text
            };
        }

        protected override void MostrarEntidades()
        {
            NegociadorGenerico<TipoObjeto> negociador = new NegociadorGenerico<TipoObjeto>();
            var data = negociador.ActualizarDs(lblCodigo.Tag.ToString(), txtCodigo.Text);
            dgvPlantillaTipo.DataSource = data;
        }

        private void CargarCodigoEnCB<T>(NegociadorGenerico<T> Negociador) where T : class, new()
        {
            try
            {
                DataTable DT = Negociador.ActualizarDs(lblCodigo.Tag.ToString()); //no pongo el otro atributo por q si es nulo trae todo y eso es lo que quiero

                if (DT.Rows.Count > 0)
                {
                    cbCodigosModif.DataSource = DT;
                    cbCodigosModif.DisplayMember = "Codigo";
                    cbCodigosModif.ValueMember = "Id";
                }
                else
                {
                    MessageBox.Show("No se encontraron códigos para cargar en el ComboBox.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error al cargar los códigos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }

}

