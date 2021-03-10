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

        private void enviar()
        {
            string detalles;
            obtenerDetalles();
            if (peso >= 0 && peso <= 100) { envio = new Carta(direccionDestino, direccionOrigen, cpDestino, cpOrigen, peso);
            } else if (peso > 100 && peso <= 2000) { envio = new Paquete(direccionDestino, direccionOrigen, cpDestino, cpOrigen, peso);
            } else { envio = new GranVolumen(direccionDestino, direccionOrigen, cpDestino, cpOrigen, peso); }
            detalles = envio.enviar();
            Console.WriteLine(detalles);
            Console.WriteLine("-- Final price: " + envio.conseguirCoste());
        }

        private void obtenerDetalles()
        {
            Console.WriteLine("\nFirst of all, introduce all data:");
            Console.WriteLine("-- Destination address");
            direccionDestino = Console.ReadLine();
            Console.WriteLine("-- Origen address");
            direccionOrigen = Console.ReadLine();
            Console.WriteLine("-- Destination CP");
            cpDestino = Console.ReadLine();
            Console.WriteLine("-- Origen CP");
            cpOrigen = Console.ReadLine();
            Console.WriteLine("-- Weight");
            peso = Convert.ToDouble(Console.ReadLine());
        }
    }
}
