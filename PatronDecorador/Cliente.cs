using System;

namespace PatronDecorador
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

        public void enviar()
        {
            obtenerDetalles();
            string detalles;
            envio = new Envio(direccionDestino, direccionOrigen, cpDestino, cpOrigen, peso);
            detalles = envio.enviar();
            Console.WriteLine(detalles);
            Console.WriteLine("\n-- Final price: ");
            Console.Write(envio.conseguirCoste() + "\n");
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
