using Datos.ManejoTablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Negociacion
{
    public class NegociadorGenerico<T> where T : class, new()
    {
        DatosEntidadGenerica<T> datosEntidad = new DatosEntidadGenerica<T>();

        public int abmNegociadorGenerico(string accion, T objeto)  // Donde T es el tipo de clase que recibe y objeto el objeto instanciado
        {
            return datosEntidad.ABMEntidad(accion, objeto);
        }

        public DataSet listadoProductos(string entidad) // Donde entidad es la entidad que quiero mostrar
        {
            return datosEntidad.ListadoEntidades(entidad);
        }
    }
}
