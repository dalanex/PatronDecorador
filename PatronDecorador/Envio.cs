using System;
using System.Collections.Generic;
using System.Text;

namespace PatronDecorador
{
    class Envio
    {
        private int envioId;
        private string direccionDestino, direccionOrigen;
        private string cpDestino, cpOrigen;
        private double peso;

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

        public double conseguirCoste() { return peso*0.39; }

        private static int lastEnvioId = 0;

        private int conseguirId() { return ++lastEnvioId; }
    }
}
