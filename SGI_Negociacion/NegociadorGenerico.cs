using Datos.ManejoTablas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SGI_Negociacion
{
    public class NegociadorGenerico<T> where T : class, new()
    {
        DatosEntidadGenerica<T> datosEntidad = new DatosEntidadGenerica<T>();

        public int abmNegociadorGenerico(string Columna, string ValorBuscado, string Accion, T Objeto)  
            // Donde T es el tipo de clase que recibe y objeto el objeto instanciado
        {
            return datosEntidad.ABMEntidad(Columna, ValorBuscado, Accion, Objeto);
        }

        public DataSet listadoEntidades(string Columna, string ValorBuscado) // Le paso el string por el cual quiera buscar
        {
            return datosEntidad.ListadoEntidades(Columna, ValorBuscado);
        }

        public DataTable ActualizarDs(string Columna, string ValorBuscado = "")
        {
            DataSet ds = listadoEntidades(Columna, ValorBuscado);

            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }

            return new DataTable();
        }
    }
}
