using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    public class Usuario : EntityBase
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Estado { get; set; }
        public int PersonaId { get; set; }
        public int TipoRolId { get; set; }


        public List<Ticket> TicketsGenerados { get; set; } = new List<Ticket>();
        public List<Ticket> TicketsAsignados { get; set; } = new List<Ticket>();
    
    }
}
