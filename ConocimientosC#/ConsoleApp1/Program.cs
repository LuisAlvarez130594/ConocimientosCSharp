using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Days = new List<string> { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            //string[] Days = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
            Console.Write("Ingresa un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            string NombreDia = Days[numero - 1];
            Console.WriteLine("Tu dia es: " + NombreDia);
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
