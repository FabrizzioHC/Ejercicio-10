using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double consumo, descuento, impuesto, subtotal, total;

            Console.WriteLine("ingresa el monto del consumo:");
            consumo = double.Parse(Console.ReadLine());

            if (consumo <= 100)
            {
                descuento = consumo * 0.1;
            }
            else
            {
                descuento = consumo * 0.2;
            }

            impuesto = consumo * 0.18;
            subtotal = consumo - descuento;
            total = subtotal + impuesto;

            Console.WriteLine($"monto del descuento: {descuento:C}");
            Console.WriteLine($"impuesto: {impuesto:C}");
            Console.WriteLine($"subtotal: {subtotal:C}");
            Console.WriteLine($"importe a pagar: {total:C}");
            Console.WriteLine("presiona cualquier tecla pa salir");
            Console.ReadKey();
        }
    }
}
