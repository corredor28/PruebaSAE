using PruebaSAE.Presentacion.Models;
using PruebaSAE.Presentacion.ServicioEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaSAE.Presentacion.Controllers
{
    public class PadreController : Controller
    {
        // GET: Padre
        public ActionResult Index()
        {
            var entidades = new EntidadesClient();
            var modelo = new ModeloPadres();

            var respuesta = entidades.ObtenerPadres();
            var padres = new List<Entidades.Padre>();

            if (respuesta.Estado)
            {
                foreach (var padreWCF in respuesta.Padres)
                {
                    var padre = new Entidades.Padre();
                    padre.Id = padreWCF.Id;
                    padre.Nombre = padreWCF.Nombre;
                    padres.Add(padre);
                }
            }
            modelo.Padres = padres;
            return View(modelo);
        }
        
        public ActionResult Hijos(long idPadre)
        {
            var entidades = new EntidadesClient();
            var modelo = new ModeloHijos();

            var respuesta = entidades.ObtenerHijosDePadre(idPadre);
            var hijos = new List<Entidades.Hijo>();

            if (respuesta.Estado)
            {
                foreach (var hijoWCF in respuesta.Hijos)
                {
                    var hijo = new Entidades.Hijo();
                    hijo.Id = hijoWCF.Id;
                    hijo.Nombre = hijoWCF.Nombre;
                    hijos.Add(hijo);
                }
            }
            modelo.Hijos = hijos;
            return View(modelo);
        }
        
        public ActionResult Crear()
        {
            return View(new ModeloPadre());
        }
        
        [HttpPost]
        public ActionResult Crear(ModeloPadre modelo)
        {
            try
            {
                var entidades = new EntidadesClient();
                var respuesta = entidades.CrearPadre(modelo.Nombre);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}
