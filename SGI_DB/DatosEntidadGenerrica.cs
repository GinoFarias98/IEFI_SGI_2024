using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Datos.ManejoTablas
{
    // MODIFICAR NOMBRE DE LAS ENTIDADES PARA QUE COINCIDA CON LAS TABLAS DEL SQL
    public class DatosEntidadGenerica<T> : DatosConexion where T : class, new()
    {
        public int ABMEntidad(string accion, T entidad)
        {
            int resultado = -1;
            string sqlQuery = GenerarComandoSQL(accion, entidad);

            SqlCommand cmd = new SqlCommand(sqlQuery, Conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error al realizar {accion} en la tabla {typeof(T).Name}", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        private string GenerarComandoSQL(string accion, T entidad)
        {
            string tabla = typeof(T).Name;
            var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            StringBuilder query = new StringBuilder();

            switch (accion)
            {
                case "alta":
                    query.Append($"INSERT INTO {tabla} (");
                    query.Append(string.Join(", ", propiedades.Select(p => p.Name)));
                    query.Append(") VALUES (");
                    query.Append(string.Join(", ", propiedades.Select(p => $"'{p.GetValue(entidad)}'")));
                    query.Append(");");
                    break;

                case "modif":
                    query.Append($"UPDATE {tabla} SET ");
                    query.Append(string.Join(", ", propiedades.Select(p => $"{p.Name}='{p.GetValue(entidad)}'")));
                    query.Append($" WHERE Id='{propiedades.FirstOrDefault(p => p.Name == "Id")?.GetValue(entidad)}';");
                    break;

                case "borrar":
                    var idValue = propiedades.FirstOrDefault(p => p.Name == "Id")?.GetValue(entidad);
                    query.Append($"DELETE FROM {tabla} WHERE Id='{idValue}';");
                    break;

                default:
                    throw new ArgumentException("Acción no reconocida");
            }

            return query.ToString();
        }

        public DataSet ListadoEntidades(string valorBuscado = "Todos")
        {
            string tabla = typeof(T).Name;
            string orden = valorBuscado != "Todos"
                ? $"SELECT * FROM {tabla} WHERE Id={int.Parse(valorBuscado)}"
                : $"SELECT * FROM {tabla}";

            SqlCommand cmd = new SqlCommand(orden, Conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception($"Error al traer elementos de la tabla {tabla}", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}