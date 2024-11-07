using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Entidades
{
    public class Ticket : EntidadBase
    {
        public string NumeroTKT { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string DescripcionProblema { get; set; }
        public string Solucion { get; set; }
        public int UsuarioReportaId { get; set; }
        public int UsuarioAsignadoId { get; set; }
        public int ObjetoId { get; set; }

        public Ticket() 
        { 
        }

        //public Ticket(string aNumeroTKT, DateTime? aFechaCreacion, DateTime? aFechaCierre, string aDescripcionProblema, string aSolucion, int aUsuarioReportaId, int aUsuarioAsignadoId, int aObjetoId)
        //{
        //    NumeroTKT = aNumeroTKT;
        //    FechaCreacion = aFechaCreacion;
        //    FechaCierre = aFechaCierre;
        //    DescripcionProblema = aDescripcionProblema;
        //    Solucion = aSolucion;
        //    UsuarioReportaId = aUsuarioReportaId;
        //    UsuarioAsignadoId = aUsuarioAsignadoId;
        //    ObjetoId = aObjetoId;
        //}
    }
}
