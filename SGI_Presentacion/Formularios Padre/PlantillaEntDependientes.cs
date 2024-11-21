using SGI_Entidades;
using SGI_Entidades.Entidades;
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
    public partial class PlantillaEntDependientes : Plantilla
    {
        public PlantillaEntDependientes()
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

        protected void ActualizarTextos(Dictionary<string, string> textos)
        {
            foreach (var item in textos)
            {
                var control = this.Controls.Find(item.Key, true).FirstOrDefault();

                if (control != null)
                {
                    switch (control)
                    {
                        case Label label:
                            label.Text = item.Value;
                            break;

                        case ComboBox comboBox:
                            comboBox.Text = item.Value; //para añadir un texto descriptivo
                            break;

                        default:
                           
                            break;
                    }
                }
            }
        }

        protected void BtAceptarOpcion_Click(object sender, EventArgs e)
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
                case Persona persona:
                    ProcesarConNegociador(new NegociadorGenerico<Persona>(), opcion, persona);
                    break;

                case Objeto objeto:
                    ProcesarConNegociador(new NegociadorGenerico<Objeto>(), opcion, objeto);
                    break;

                case Usuario usuario:
                    ProcesarConNegociador(new NegociadorGenerico<Usuario>(), opcion, usuario);
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
                    // en el prop3 tiene que estar un identificador

                    negociador.abmNegociadorGenerico(LblProp3.Tag.ToString(), TxtProp3.Text, opcion, entidad); 
                    MessageBox.Show("Baja realizada exitosamente.");
                    break;

                case "modificar":

                    if (TxtProp3.Text == string.Empty)
                    {
                        MessageBox.Show($"Seleccione un {LblProp3.Tag.ToString()} para modificar ua entidad.", "Advertencia, campo incompleto o nulo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string IdentificadorSeleccionado = TxtProp3.Text;

                    negociador.abmNegociadorGenerico(LblProp3.Tag.ToString(), IdentificadorSeleccionado, opcion, entidad);
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


        protected void CargarCodigoEnCB<T>(NegociadorGenerico<T> Negociador) where T : class, new()
        {
            try
            {
                DataTable DT = Negociador.ActualizarDs("Codigo"); //no pongo el otro atributo por q si es nulo trae todo y eso es lo que quiero

                if (DT.Rows.Count > 0)
                {
                    Cbx1.DataSource = DT;
                    Cbx1.DisplayMember = "Codigo";
                    Cbx1.ValueMember = "Id";
                    Cbx1.Refresh();
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


        protected virtual object CrearEntidad()
        {
            throw new NotImplementedException("Debe implementarse en las clases derivadas.");
        }

        protected virtual void MostrarEntidades()
        {
            throw new NotImplementedException("Debe implementarse en las clases derivadas.");
        }

        protected Label lblProp1 => LblProp1;
        protected Label lblProp2 => LblProp2;
        protected Label lblProp3 => LblProp3;
        protected Label lblProp4 => LblProp4;
        protected Label lblProp5 => LblProp5;
        protected Label lblProp6 => LblProp6;
        protected Label lblProp7 => LblProp7;
        protected Label lblProp8 => LblProp8;
        protected Label lblCb1 => LblCb1;
        protected Label lblCb2 => LblCb2;

        protected TextBox txtProp1 => TxtProp1;
        protected TextBox txtProp2 => TxtProp2;
        protected TextBox txtProp3 => TxtProp3;
        protected TextBox txtProp4 => TxtProp4;
        protected TextBox txtProp5 => TxtProp5;
        protected TextBox txtProp6 => TxtProp6;
        protected TextBox txtProp7 => TxtProp7;
        protected TextBox txtProp8 => TxtProp8;

        protected ComboBox cbx1 => Cbx1;
        protected ComboBox cbx2 => Cbx2;
        protected ComboBox cbOpciones => CbOpciones;

        protected DataGridView dgvPlantillaTipo => DgvPlantillaTipo;

    }
}
