using SGI_Negociacion;
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

namespace SGI_Presentacion.Formularios_Padre
{
    public partial class PlantillaTablaTipo : Plantilla 
    {
        public PlantillaTablaTipo()
        {
            InitializeComponent();
            ConfigComboBox();

            Plantilla plantilla = new Plantilla();

            this.Size = plantilla.Size;

            this.StartPosition = FormStartPosition.CenterParent;

            this.lblTitulo.Text = this.Text;
        }

        protected virtual void ConfigComboBox()  
        {
            CbOpciones.Items.Add("Alta");
            CbOpciones.Items.Add("Baja");
            CbOpciones.Items.Add("Modificar");
            CbOpciones.Items.Add("Mostrar");

            // puede ser utilizado o sobrescrito por cualquier clase que herede de la clase actual, pero no por clases externas que no estén en la jerarquía

        }

        protected virtual void BtAceptarOpcion_Click(object sender, EventArgs e)
        {

            if (CbOpciones.SelectedItem == null || CbOpciones.SelectedItem.ToString() == "Opciones")
            {
                MessageBox.Show("Seleccione una opcion valida antes de continuar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string Opcion = CbOpciones.SelectedItem.ToString().ToLower();
            NegociadorGenerico<object> Negociador = new NegociadorGenerico<object>();
            object Entidad = CrearEntidad();

            switch (Opcion)
            {

                case "alta":
                    Negociador.abmNegociadorGenerico(Opcion, Entidad);
                    MessageBox.Show("Alta realizada exitosamente.");
                    break;

                case "baja":
                    Negociador.abmNegociadorGenerico(Opcion, Entidad);
                    MessageBox.Show("Baja realizada exitosamente.");
                    break;

                case "modificar":
                    Negociador.abmNegociadorGenerico(Opcion, Entidad);
                    MessageBox.Show("modificacion realizada exitosamente.");
                    break;

                case "mostrar":
                    MostrarEntidades();
                    break;

                default:
                    break;
            }

        }

        protected virtual object CrearEntidad()
        {
            throw new NotImplementedException();
        }

        protected virtual void MostrarEntidades()
        {
            NegociadorGenerico<Object> NegociadorMostrar = new NegociadorGenerico<Object>();
            var DataSet = NegociadorMostrar.listadoProductos(typeof(Object).Name);
            DgvPlantillaTipo.DataSource = DataSet.Tables[0];
        }

        protected TextBox txtNombre => TxtNombre;
        protected TextBox txtCodigo => TxtCodigo;
        protected DataGridView dgvPlantillaTipo => DgvPlantillaTipo;
    }
}
