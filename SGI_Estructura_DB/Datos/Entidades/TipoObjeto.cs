using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(Codigo), nameof(Nombre), Name = "TipoObjeto_Cod_Y_Nombre_UQ", IsUnique = true)]
    public class TipoObjeto : EntityBase
    {
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Nombre { get; set; }

        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Codigo { get; set; }

        public List<Objeto> Objetos { get; set; } = new List<Objeto>();
    }
}
