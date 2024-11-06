using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Entidades
{
    // abstract para que solo se propague por las entidades que hereden de esta base
    public abstract class TablaTipo : EntidadBase
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        // solo las entidades que hereden de esta llaman al constructor
        protected TablaTipo(string aNombre, string aCodigo)
        {
            Nombre = aNombre;
            Codigo = aCodigo;
        }

    }
    
}