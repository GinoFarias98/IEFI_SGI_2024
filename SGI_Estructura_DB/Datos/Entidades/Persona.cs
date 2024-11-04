using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(NumDoc), nameof(TipoDocumentoId), Name = "IX_NumDoc", IsUnique = true)]
    public class Persona : EntityBase
    {
        [MaxLength(50, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Nombre { get; set; }

        [MaxLength(50, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Apellido { get; set; }

        public int NumDoc { get; set; }
        public int Telefono { get; set; }
        public bool Estado { get; set; }

        [MaxLength(10, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string CodBox { get; set; } // codigo del box donde trabaja o donde trabaja el técnico

        public int TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public Usuario Usuario { get; set; }
    }
}
