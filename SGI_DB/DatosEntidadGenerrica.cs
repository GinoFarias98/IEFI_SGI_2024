using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Reflection;
using System.Linq;

namespace Datos.ManejoTablas
{
    public class DatosEntidadGenerica<T> : DatosConexion where T : class, new()
    {
        public int ABMEntidad(string accion, T entidad)
        {
            int resultado = -1;
            string sqlQuery = GenerarComandoSQL(accion, entidad);

            SqlCommand cmd = new SqlCommand(sqlQuery, Conexion);
            var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var PropiedadesSinId = propiedades.Where(p => p.Name != "Id").ToList();

            // Agregar parámetros
            for (int i = 0; i < PropiedadesSinId.Count; i++)
            {
                var valor = PropiedadesSinId[i].GetValue(entidad);

                // Verificar si el valor es null y asignar DBNull.Value solo si es necesario
                if (valor == null)
                {
                    cmd.Parameters.AddWithValue($"@param{i}", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue($"@param{i}", valor);
                }
            }

            // No es necesario agregar el parámetro ID al comando, ya que lo maneja la base de datos

            try
            {
                Abrirconexion();

                if (accion == "alta")
                {
                    cmd.ExecuteNonQuery();
                    // No se necesita recuperar el ID de la base de datos ni asignarlo a la entidad
                }
                else
                {
                    resultado = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                var parametros = string.Join(", ", cmd.Parameters.Cast<SqlParameter>()
                    .Select(p => $"{p.ParameterName}={p.Value}"));
                throw new Exception($"Error al realizar {accion} en la tabla {typeof(T).Name}. Consulta: {sqlQuery}. Parámetros: {parametros}", e);
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

            var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);  // <-- devuelve un array
            StringBuilder query = new StringBuilder();

            var PropiedadesSinId = propiedades.Where(p => p.Name != "Id").ToList(); // listar las props sin id 

            switch (accion)
            {
                case "alta":
                    query.Append($"INSERT INTO {tabla} (");
                    query.Append(string.Join(", ", PropiedadesSinId.Select(p => p.Name)));
                    query.Append(") VALUES (");

                    // agrego parametros para evitar hacer concatenaciones y evitar sqlInyection
                    for (int i = 0; i < PropiedadesSinId.Count; i++)
                    {
                        query.Append($"@param{i}, ");
                    }
                    query.Length -= 2; // elimino la coma y ultimo espacio del string de arriba
                    query.Append(");");
                    break;

                case "modificar":
                    query.Append($"UPDATE {tabla} SET ");
                    for (int i = 0; i < propiedades.Length; i++)
                    {
                        query.Append($"{propiedades[i].Name}=@param{i}, ");
                    }
                    query.Length -= 2; // elimino la coma y ultimo espacio del string de arriba
                    query.Append($" WHERE Id=@Id;"); // parametrizo también el Id

                    break;

                case "baja":
                    query.Append($"DELETE FROM {tabla} WHERE Id=@Id;");
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

            if (valorBuscado != "Todos")
            {
                cmd.Parameters.AddWithValue("@Id", int.Parse(valorBuscado));
            }

            try
            {
                Abrirconexion();
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