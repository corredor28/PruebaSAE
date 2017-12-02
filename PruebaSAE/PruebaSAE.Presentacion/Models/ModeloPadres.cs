using PruebaSAE.Presentacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaSAE.Presentacion.Models
{
    public class ModeloPadres
    {
        public IEnumerable<Padre> Padres { get; set; }
    }
}