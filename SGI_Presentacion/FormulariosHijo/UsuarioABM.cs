﻿using System;
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
    public partial class UsuarioABM : Plantilla
    {
        public UsuarioABM()
        {
            InitializeComponent();

            Plantilla plantilla = new Plantilla();

            this.Size = plantilla.Size;

            this.StartPosition = FormStartPosition.CenterParent;

            this.lblTitulo.Text = this.Text;

        }
    }
}
