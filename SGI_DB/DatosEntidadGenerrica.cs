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
        public int ABMEntidad(string Columna, string ValorBuscado, string Accion, T Entidad)
        {
            int resultado = -1;
            string sqlQuery = GenerarComandoSQL(Columna, ValorBuscado, Accion, Entidad);

            SqlCommand cmd = new SqlCommand(sqlQuery, Conexion);
            var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var PropiedadesSinId = propiedades.Where(p => p.Name != "Id").ToList();

            if(Accion == "alta" || Accion == "modificar")
            {
                for (int i = 0; i < PropiedadesSinId.Count; i++)
                {
                    var valor = PropiedadesSinId[i].GetValue(Entidad);

                    // Verifica si el valor es null y asignar DBNull.Value solo si es necesario
                    if (valor == null)
                    {
                        // Agregar parámetros
                        cmd.Parameters.AddWithValue($"@param{i}", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue($"@param{i}", valor);
                    }
                }

                if (Accion == "modificar")
                {
                    cmd.Parameters.AddWithValue("@ValorBuscado", ValorBuscado);
                }
            }
            else if (Accion == "baja")
            {
                cmd.Parameters.AddWithValue("@ValorBuscado", ValorBuscado);
            }

            try
            {
                Abrirconexion();

                if (Accion == "alta")
                {
                    cmd.ExecuteNonQuery();
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
                throw new Exception($"Error al realizar {Accion} en la tabla {typeof(T).Name}. Consulta: {sqlQuery}. Parámetros: {parametros}", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return resultado;
        }

        private string GenerarComandoSQL(string Columna, string ValorBuscado, string Accion, T Entidad)
        {
            string tabla = typeof(T).Name;

            var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);  // <-- devuelve un array
            StringBuilder query = new StringBuilder();

            var PropiedadesSinId = propiedades.Where(p => p.Name != "Id").ToList(); // listar las props sin id 

            switch (Accion)
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
                    for (int i = 0; i < PropiedadesSinId.Count; i++)
                    {
                        query.Append($"{PropiedadesSinId[i].Name}=@param{i}, ");
                    }
                    query.Length -= 2; // elimino la coma y ultimo espacio del string de arriba
                    query.Append($" WHERE {Columna}=@ValorBuscado;"); // parametrizo la columna y el valor

                    break;

                case "baja":
                    query.Append($"DELETE FROM {tabla} WHERE {Columna}=@ValorBuscado;");
                    break;

                default:
                    throw new ArgumentException("Acción no reconocida");
            }

            return query.ToString();
        }

        public DataSet ListadoEntidades(string Columna, string ValorBuscado)
        {
            string tabla = typeof(T).Name;
            string orden;

            if (ValorBuscado != "")
            {
                orden = $"SELECT * FROM {tabla} WHERE {Columna} = @ValorBuscado";
            }
            else
            {
                orden = $"SELECT * FROM {tabla}";
            }

            SqlCommand cmd = new SqlCommand(orden, Conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            if (ValorBuscado != "Todos")
            {
                cmd.Parameters.AddWithValue("@ValorBuscado", ValorBuscado);
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