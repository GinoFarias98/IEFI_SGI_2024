using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    public class TipoDocumento : EntityBase
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

    }
}
