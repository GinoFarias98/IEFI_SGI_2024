using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DatosConexion
    {
        public SqlConnection Conexion;
        public string CadenaConexion = "Server=DESKTOP-9IG25EE\\SQLEXPRESS;Database=SGI2024;Trusted_Connection=True;TrustServerCertificate=True;";

        public DatosConexion()
        {
            Conexion = new SqlConnection(CadenaConexion);
        }

        public void Abrirconexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State ==
                ConnectionState.Closed)
                    Conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

        public void Cerrarconexion()
        {
            try
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }
}
