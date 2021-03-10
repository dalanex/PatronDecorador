using System;

namespace PatronDecorador
{
    class Cliente
    {
        private static string direccionEnvio, direccionOrigen;
        private static string codigoPostalDestino, codigoPostalOrigen;
        private static double peso;
        private Envio envio;

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO AMAZING!!");
            Console.WriteLine("---------------------");
        }

        private void obtenerDetalles()
        {
            Console.WriteLine("First of all, introduce all data:");
            Console.WriteLine("-- Destination address");
            direccionEnvio = Console.ReadLine();
            Console.WriteLine("-- Origen address");
            direccionOrigen = Console.ReadLine();
            Console.WriteLine("-- Destination CP");
            codigoPostalDestino = Console.ReadLine();
            Console.WriteLine("-- Origen CP");
            codigoPostalOrigen = Console.ReadLine();
            Console.WriteLine("-- Weight");
            peso = Convert.ToDouble(Console.ReadLine());
        }
    }
}
