using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaSAE.Presentacion.Entidades
{
    public class Hijo
    {
        public long Id { get; set; }
        public long IdPadre { get; set; }
        public string Nombre { get; set; }
    }
}