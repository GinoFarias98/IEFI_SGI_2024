using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(Codigo), nameof(Nombre), Name = "TipoDocumento_Cod_Y_Nombre_UQ", IsUnique = true)]
    public class TipoDocumento : EntityBase
    {
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Nombre { get; set; }

        [MaxLength(4, ErrorMessage = "Máximo número de caracteres {1}.")]
        public string Codigo { get; set; }

        public List<Persona> Personas { get; set; } = new List<Persona>();

    }
}
