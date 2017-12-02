using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaSAE.Negocio.Entidades
{
    public class Padre
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public IEnumerable<Hijo> Hijos { get; set; }
    }
}