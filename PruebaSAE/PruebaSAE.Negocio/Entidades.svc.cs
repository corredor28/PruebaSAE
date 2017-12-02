using PruebaSAE.Negocio.Acceso;
using PruebaSAE.Negocio.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PruebaSAE.Negocio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Negocio : IEntidades
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public RespuestaPadres ObtenerPadres()
        {
            var accesoPadre = new AccesoPadre();
            return accesoPadre.ObtenerPadres();
        }

        public RespuestaHijos ObtenerHijosDePadre(long idPadre)
        {
            var accesoHijo = new AccesoHijo();
            return accesoHijo.ObtenerHijosDePadre(idPadre);
        }

        public RespuestaPadres CrearPadre(string nombre)
        {
            var accesoPadre = new AccesoPadre();
            return accesoPadre.CrearPadre(nombre);
        }

        public RespuestaHijos CrearHijo(long idPadre, string nombre)
        {
            var accesoHijo = new AccesoHijo();
            return accesoHijo.CrearHijo(idPadre, nombre);
        }
    }
}
