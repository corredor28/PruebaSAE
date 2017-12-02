using PruebaSAE.Negocio.Entidades;
using PruebaSAE.Negocio.Respuestas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaSAE.Negocio.Acceso
{
    public class AccesoHijo
    {
        public RespuestaHijos ObtenerHijosDePadre(long idPadre)
        {
            var respuesta = new RespuestaHijos();
            var hijos = new List<Hijo>();

            var conexion = new Conexion();
            using (var conexionSQL = conexion.ConexionSQL)
            {
                try
                {
                    if (conexionSQL.State != ConnectionState.Open)
                        conexionSQL.Open();

                    var comando = new SqlCommand("ConsultarHijosPorPadre", conexionSQL);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idPadre", idPadre);

                    var reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var hijo = new Hijo();
                        hijo.Id = Convert.ToInt64(reader["Id"]);
                        hijo.IdPadre = Convert.ToInt64(reader["IdPadre"]);
                        hijo.Nombre = Convert.ToString(reader["Nombre"]);
                        hijos.Add(hijo);
                    }

                    respuesta.Estado = true;
                    respuesta.Hijos = hijos;
                }
                catch (Exception ex)
                {
                    respuesta.Estado = false;
                    respuesta.Mensaje = ex.Message;
                }
            }

            return respuesta;
        }

        public RespuestaHijos CrearHijo(long idPadre, string nombre)
        {
            var respuesta = new RespuestaHijos();

            var conexion = new Conexion();
            using (var conexionSQL = conexion.ConexionSQL)
            {
                try
                {
                    if (conexionSQL.State != ConnectionState.Open)
                        conexionSQL.Open();

                    var comando = new SqlCommand("InsertarHijo", conexionSQL);
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@idPadre", idPadre);
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.ExecuteNonQuery();

                    respuesta.Estado = true;
                }
                catch (Exception ex)
                {
                    respuesta.Estado = false;
                    respuesta.Mensaje = ex.Message;
                }
            }

            return respuesta;
        }
    }
}