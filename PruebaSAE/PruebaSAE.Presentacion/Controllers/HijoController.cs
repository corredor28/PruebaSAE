using PruebaSAE.Presentacion.Models;
using PruebaSAE.Presentacion.ServicioEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaSAE.Presentacion.Controllers
{
    public class HijoController : Controller
    {
        // GET: Hijo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Crear(long idPadre)
        {
            var modeloHijo = new ModeloHijo();
            modeloHijo.IdPadre = idPadre;
            return View(modeloHijo);
        }

        // POST: Padre/Create
        [HttpPost]
        public ActionResult Crear(ModeloHijo modelo)
        {
            try
            {
                var entidades = new EntidadesClient();
                var respuesta = entidades.CrearHijo(modelo.IdPadre, modelo.Nombre);

                return RedirectToAction("Index", "Padre");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View();
            }
        }
    }
}