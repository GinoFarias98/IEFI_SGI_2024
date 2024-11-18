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
    public partial class TipoDocumentoABM : PlantillaTablaTipo
    {
        public TipoDocumentoABM()
        {
            InitializeComponent();

            Plantilla plantilla = new Plantilla();

            this.Size = plantilla.Size;

            this.StartPosition = FormStartPosition.CenterParent;

            this.lblTitulo.Text = this.Text;

        }

        protected override void ConfigComboBox()
        {
            base.ConfigComboBox();
        }

        protected override object CrearEntidad()
        {
            TipoDocumento Tdoc = new TipoDocumento
            {
                Nombre = txtNombre.Text,
                Codigo = txtCodigo.Text
            };
            return Tdoc;
        }

        protected override void MostrarEntidades()
        {
            NegociadorGenerico<TipoDocumento> NegTipoRol = new NegociadorGenerico<TipoDocumento>();
            var DataSet = NegTipoRol.listadoProductos("TipoDocumento");
            dgvPlantillaTipo.DataSource = DataSet.Tables[0];
        }
    }

}

