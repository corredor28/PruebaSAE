﻿using PruebaSAE.Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaSAE.Negocio.Respuestas
{
    public class RespuestaHijos
    {
        public bool Estado { get; set; }
        public string Mensaje { get; set; }
        public IEnumerable<Hijo> Hijos { get; set; }
    }
}