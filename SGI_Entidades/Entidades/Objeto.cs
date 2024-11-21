using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Entidades.Entidades
{
    public class Objeto : EntidadBase
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public int TipoObjeto_Id { get; set; }

        public Objeto()
        {

        }

        //public Objeto(string aNombre, string aDescripcion, string aMarca, string aModelo, string aNumeroSerie, int tipoObjetoId)
        //{
        //    Nombre = aNombre;
        //    Descripcion = aDescripcion;
        //    Marca = aMarca;
        //    Modelo = aModelo;
        //    NumeroSerie = aNumeroSerie;
        //    TipoObjetoId = tipoObjetoId;
        //}
    }
}
