using System;

namespace Decorador_añadiendo_tipos
{
    class Cliente
    {
        private string direccionDestino, direccionOrigen;
        private string cpDestino, cpOrigen;
        private double peso;
        private Envio envio;
        private static Cliente cliente;

        public Cliente() { }

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO AMAZING!!");
            Console.WriteLine("---------------------");
            cliente = new Cliente();
            cliente.enviar();
        }

        private void enviar() { }
    }
}
