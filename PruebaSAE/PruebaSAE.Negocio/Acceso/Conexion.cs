using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PruebaSAE.Negocio.Acceso
{
    public class Conexion
    {
        private SqlConnection _conexionSQL = null;

        public SqlConnection ConexionSQL
        {
            get { return _conexionSQL; }
            set { _conexionSQL = value; }
        }

        public Conexion()
        {
            string cadenaDeConexion = ConfigurationManager.ConnectionStrings["PruebaSAE"].ConnectionString;
            _conexionSQL = new SqlConnection(cadenaDeConexion);
        }
    }
}