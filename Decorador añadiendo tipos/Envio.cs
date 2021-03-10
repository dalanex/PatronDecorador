using System;
using System.Collections.Generic;
using System.Text;

namespace Decorador_añadiendo_tipos
{
    abstract class Envio
    {
        private int envioId;
        private string direccionDestino, direccionOrigen;
        private string cpDestino, cpOrigen;
        protected double peso;

        public Envio(string direccionDestino, string direccionOrigen, string cpDestino, string cpOrigen, double peso)
        {
            this.direccionDestino = direccionDestino;
            this.direccionOrigen = direccionOrigen;
            this.cpDestino = cpDestino;
            this.cpOrigen = cpOrigen;
            this.peso = peso;
            envioId = conseguirId();
        }

        public string enviar()
        {
            string res = "\nThe shipment with ID: " + envioId;
            res += "\nWill be delivered in: " + direccionDestino + ", " + cpDestino;
            res += "\nSent from: " + direccionOrigen + ", " + cpOrigen;
            return res;
        }

        public abstract double conseguirCoste();

        private static int lastEnvioId = 0;

        private int conseguirId() { return ++lastEnvioId; }
    }
}