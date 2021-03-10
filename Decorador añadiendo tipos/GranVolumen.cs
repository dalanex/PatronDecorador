using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador_añadiendo_tipos
{
    class GranVolumen : Envio
    {
        public GranVolumen(string direccionDestino, string direccionOrigen, string cpDestino, string cpOrigen, double peso) : base(
            direccionDestino, direccionOrigen, cpDestino, cpOrigen, peso) { }

        public override double conseguirCoste() { return peso * 0.25; }
    }
}
