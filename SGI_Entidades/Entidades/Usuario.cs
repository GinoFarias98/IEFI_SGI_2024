using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Entidades
{
    public class Usuario : EntidadBase
    {
        public string UserName { get; set; }
        public string Contrasena { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        public int PersonasId { get; set; }
        public int TipoRolId { get; set; }

        public Usuario(string aUserName, string aContrasena, string aEmail, bool aEstado, int aPersonasId, int aTipoRolId)
        {
            UserName = aUserName;
            Contrasena = aContrasena;
            Email = aEmail;
            Estado = aEstado;
            PersonasId = aPersonasId;
            TipoRolId = aTipoRolId;
        }

    }
}
