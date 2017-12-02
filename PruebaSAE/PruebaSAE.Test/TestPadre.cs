using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaSAE.Test.ServicioEntidades;

namespace PruebaSAE.Test
{
    [TestClass]
    public class TestPadre
    {
        [TestMethod]
        public void TestCrearPadre()
        {
            var servicio = new EntidadesClient();
            var nombrePrueba = "Padre prueba - " + DateTime.Now.ToString();
            var respuesta = servicio.CrearPadre(nombrePrueba);
            
            // Validar objeto de respuesta
            Assert.IsNotNull(respuesta);

            // Validar resultado
            Assert.IsTrue(respuesta.Estado);

            // Ahora consultar para validar que existe
            respuesta = servicio.ObtenerPadres();
            
            Assert.IsNotNull(respuesta.Padres);
            var existePadre = false;
            foreach (var padreWCF in respuesta.Padres)
            {
                if (padreWCF.Nombre == nombrePrueba)
                {
                    existePadre = true;
                }
            }
            Assert.IsTrue(existePadre);
        }
    }
}
