using Microsoft.EntityFrameworkCore;
using SGI_Estructura_DB.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos
{
    public class Contexto : DbContext
    {
        public DbSet<Objeto> Objetos { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TipoDocuemtno> TipoDocuemtno { get; set; }
        public DbSet<TipoObjeto> TipoObjeto { get; set; }
        public DbSet<Objeto> Objetos { get; set; }
        public DbSet<Objeto> Objetos { get; set; }


    }
}
