using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(UserName),Name = "UQ_UserNAme", IsUnique = true)]
    [Index(nameof(PersonaId), Name = "UQ_PersonaId", IsUnique = true)]
    [Index(nameof(TipoRolId), Name = "UQ_TipoRolId", IsUnique = true)]
    public class Usuario : EntityBase
    {
        [MaxLength(30, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string UserName { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Password { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Email { get; set; }


        [MaxLength(20, ErrorMessage = "Máximo número de caracteres permitidos: {1}.")]
        public string Estado { get; set; }


        public int PersonaId { get; set; }
        public Persona Persona { get; set; }


        public int TipoRolId { get; set; }
        public TipoRol TipoRol {get;set;}


        public List<Ticket> TicketsGenerados { get; set; } = new List<Ticket>();
        public List<Ticket> TicketsAsignados { get; set; } = new List<Ticket>();
    
    }
}
