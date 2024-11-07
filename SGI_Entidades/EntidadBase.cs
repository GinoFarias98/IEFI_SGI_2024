using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Entidades
{
    // abstract para que solo se propague por las entidades que hereden de esta base
    public abstract class EntidadBase
    {
        public int Id { get; set; }

        protected EntidadBase()
        {
            
        }

    }
}
