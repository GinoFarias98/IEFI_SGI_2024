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
    public partial class TipoObjetoABM : Plantilla
    {
        public TipoObjetoABM()
        {
            InitializeComponent();
            ConfigComboBox();

            Plantilla plantilla = new Plantilla();

            this.Size = plantilla.Size;

            this.StartPosition = FormStartPosition.CenterParent;

            this.lblTitulo.Text = this.Text;

        }

        protected void ConfigComboBox()
        {
            CbTObjeto.Items.Add("Alta");
            CbTObjeto.Items.Add("Baja");
            CbTObjeto.Items.Add("Modificar");
            CbTObjeto.Items.Add("Mostrar");

            // puede ser utilizado o sobrescrito por cualquier clase que herede de la clase actual, pero no por clases externas que no estén en la jerarquía

        }

        private void BtAceptarOpciones_Click(object sender, EventArgs e)
        {
            string Opcion = CbTObjeto.SelectedItem.ToString().ToLower();
            NegociadorGenerico<TipoObjeto> negociadorGenerico = new NegociadorGenerico<TipoObjeto>();

            TipoObjeto Tobjeto = new TipoObjeto
            {
                Nombre = TxtNombre.Text,
                Codigo = TxtCodigo.Text
            };

            switch (Opcion)
            {

                case "alta":
                    negociadorGenerico.abmNegociadorGenerico(Opcion, Tobjeto);
                    MessageBox.Show("Alta realizada exitosamente.");
                    break;

                case "baja":
                    negociadorGenerico.abmNegociadorGenerico(Opcion, Tobjeto);
                    MessageBox.Show("Baja realizada exitosamente.");
                    break;

                case "modificar":
                    negociadorGenerico.abmNegociadorGenerico(Opcion, Tobjeto);
                    MessageBox.Show("modificacion realizada exitosamente.");
                    break;

                case "mostrar":
                    var DataSet = negociadorGenerico.listadoProductos("TipoObjeto");
                    DgvTipoObjeto.DataSource = DataSet.Tables[0];
                    break;

                default:
                    break;
            }  

        }
    }

}

