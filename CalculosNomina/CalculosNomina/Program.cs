using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Angel Calderon Ramirez

namespace CalculosNomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NombreCliente = string.Empty;
            double sueldoActual = 1500.75d;
            double sueldoFinal = 0d;
            double montoadepositar = 0d;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===============================");
            Console.WriteLine("  Bienvenido  ");
            Console.WriteLine("===============================");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");

            Console.Write("Ingrese el nombre del Cliente: ");
            NombreCliente = Console.ReadLine();

            Console.WriteLine("\n");
            Console.Write("Ingrese el monto a depositar: ");
            if (! double.TryParse(Console.ReadLine(), out montoadepositar ))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Error por favor ingrese valores numerios no letras Eje: 123");
                return;
            }

            sueldoFinal = (sueldoActual + montoadepositar);

            Console.WriteLine("===============================");
            Console.WriteLine("  Baucher cliente  ");
            Console.WriteLine("===============================");
            Console.WriteLine("\n");
            Console.WriteLine($"Cliente: {NombreCliente}");
            Console.WriteLine($"Sueldo Actual: {sueldoActual}");
            Console.WriteLine($"Sueldo Depositado: {montoadepositar}");
            Console.WriteLine($"Sueldo Final: {sueldoFinal}");

            Console.ReadLine();    

        }
    }
}
