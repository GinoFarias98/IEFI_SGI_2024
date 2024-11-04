using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Estructura_DB.Datos.Entidades
{
    [Index(nameof(NumeroTKT), Name = "UQ_NumeroTKT", IsUnique = true)]
    [Index(nameof(UsuarioReportaId), Name = "IX_UsuarioReportaId", IsUnique = false)]
    [Index(nameof(UsuarioGeneraId), Name = "IX_UsuarioGeneraId", IsUnique = false)]
    public class Ticket : EntityBase
    {
        public int NumeroTKT { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string DetalleProblema { get; set; }
        public string DetalleSolucion { get; set; }

        public int UsuarioReportaId { get; set; }
        public int UsuarioGeneraId { get; set; }

        public int ObjetoId { get; set; }
        public Objeto Objeto { get; set; }

        public List<Usuario> Usuarios { get; set; } = new List<Usuario>(); 

    }
}
