using SGI_Entidades;
using SGI_Negociacion;
using SGI_Presentacion.Formularios_Hijo;
using System;
using System.Data;
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
            CbOpciones.Items.AddRange(new[] { "Alta", "Baja", "Modificar", "Mostrar" });
        }



        protected virtual void BtAceptarOpcion_Click(object sender, EventArgs e)
        {
            if (CbOpciones.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una opción válida antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcion = CbOpciones.SelectedItem.ToString().ToLower();
            ProcesarOpcion(opcion);
        }

        protected virtual void ProcesarOpcion(string opcion)
        {
            object entidad = CrearEntidad();
            if (entidad == null)
            {
                MessageBox.Show("Entidad no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (entidad)
            {
                case TipoObjeto tipoObjeto:
                    ProcesarConNegociador(new NegociadorGenerico<TipoObjeto>(), opcion, tipoObjeto);
                    break;

                case TipoDocumento tipoDocumento:
                    ProcesarConNegociador(new NegociadorGenerico<TipoDocumento>(), opcion, tipoDocumento);
                    break;

                case TipoRol rol:
                    ProcesarConNegociador(new NegociadorGenerico<TipoRol>(), opcion, rol);
                    break;

                default:
                    MessageBox.Show("Tipo de entidad no soportado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ProcesarConNegociador<T>(NegociadorGenerico<T> negociador, string opcion, T entidad) where T : class, new()
        {
            switch (opcion)
            {
                case "alta":
                    negociador.abmNegociadorGenerico(string.Empty, string.Empty, opcion, entidad);
                    MessageBox.Show("Alta realizada exitosamente.");
                    break;

                case "baja":

                    negociador.abmNegociadorGenerico(LblCodigo.Tag.ToString(), txtCodigo.Text, opcion, entidad);
                    MessageBox.Show("Baja realizada exitosamente.");
                    break;

                case "modificar":

                    if (CbCodigosModif.SelectedItem == null)
                    {
                        MessageBox.Show("Seleccione un código para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string CodigoSeleccionado = CbCodigosModif.Text;

                    negociador.abmNegociadorGenerico(LblCodigo.Tag.ToString(), CodigoSeleccionado, opcion, entidad);
                    MessageBox.Show("Modificación realizada exitosamente.");
                    break;

                case "mostrar":
                    MostrarEntidades();
                    break;

                default:
                    MessageBox.Show("Opción no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }



        protected virtual object CrearEntidad()
        {
            throw new NotImplementedException("Debe implementarse en las clases derivadas.");
        }

        protected virtual void MostrarEntidades()
        {
            throw new NotImplementedException("Debe implementarse en las clases derivadas.");
        }

        protected TextBox txtNombre => TxtNombre;
        protected TextBox txtCodigo => TxtCodigo;
        protected DataGridView dgvPlantillaTipo => DgvPlantillaTipo;
        protected Label lblCodigo => LblCodigo;
        protected Label lblCodModif => LblCodModif;
        protected ComboBox cbCodigosModif => CbCodigosModif;
        protected ComboBox cbOpciones => CbOpciones;


    }
}