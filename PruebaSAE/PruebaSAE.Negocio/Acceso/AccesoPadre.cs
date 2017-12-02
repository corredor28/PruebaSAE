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
    public class AccesoPadre
    {
        public RespuestaPadres ObtenerPadres()
        {
            var respuesta = new RespuestaPadres();
            var padres = new List<Padre>();

            var conexion = new Conexion();
            using (var conexionSQL = conexion.ConexionSQL)
            {
                try
                {
                    if (conexionSQL.State != ConnectionState.Open)
                        conexionSQL.Open();

                    var comando = new SqlCommand("ConsultarPadres", conexionSQL);
                    comando.CommandType = CommandType.StoredProcedure;
                    var reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        var padre = new Padre();
                        padre.Id = Convert.ToInt64(reader["Id"]);
                        padre.Nombre = Convert.ToString(reader["Nombre"]);
                        padres.Add(padre);
                    }
                    
                    respuesta.Estado = true;
                    respuesta.Padres = padres;
                }
                catch (Exception ex)
                {
                    respuesta.Estado = false;
                    respuesta.Mensaje = ex.Message;
                }
            }
            
            return respuesta;
        }

        public RespuestaPadres CrearPadre(string nombre)
        {
            var respuesta = new RespuestaPadres();

            var conexion = new Conexion();
            using (var conexionSQL = conexion.ConexionSQL)
            {
                try
                {
                    if (conexionSQL.State != ConnectionState.Open)
                        conexionSQL.Open();

                    var comando = new SqlCommand("InsertarPadre", conexionSQL);
                    comando.CommandType = CommandType.StoredProcedure;

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