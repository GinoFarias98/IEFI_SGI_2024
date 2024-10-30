using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    public class Persona : EntityBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NumDoc { get; set; }
        public int Telefono { get; set; }
        public bool Estado { get; set; }
        public string CodBox { get; set; }
        public int TipoDocumentoId { get; set; }
    }
}
