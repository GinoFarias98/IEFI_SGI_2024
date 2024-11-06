using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Entidades
{
    public class Persona : EntidadBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumDoc { get; set; }
        public int Telefono { get; set; }
        public bool Estado { get; set; }
        public string NumBox { get; set; }
        public int TipoDocumentoId { get; set; }


        public Persona(string aNombre, string aApellido, string aNumDoc, int aTelefono, bool aEstado, string aNumBox, int aTipoDocumentoId)
        {
                Nombre = aNombre;
                Apellido = aApellido;
                NumDoc = aNumDoc;
                Telefono = aTelefono;
                Estado = aEstado;
                Telefono = aTelefono;
                Estado = aEstado;
                NumBox = aNumBox;
                TipoDocumentoId = aTipoDocumentoId;
        }
    }
}
