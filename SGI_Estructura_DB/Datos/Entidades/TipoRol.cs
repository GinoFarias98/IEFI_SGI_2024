﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(Codigo), Name = "UQ_Codigo", IsUnique = true)]
    public class TipoRol : EntityBase
    {
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Nombre { get; set; }


        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Codigo { get; set; }


        public List<Usuario> Usuarios { get; set; } = new List<Usuario>();
    }
}
