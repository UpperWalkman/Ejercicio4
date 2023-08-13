using System;
using System.Linq;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un caracter a contar");
            string leerPirmeraLineea = Console.ReadLine();

            Console.WriteLine("Escribe una serie de caracteres sin espacios");
            string leerSerieCaracteres = Console.ReadLine();
            char[] caracteres = leerSerieCaracteres.ToCharArray();
            int totalRepetido = caracteres.Count(car => car == char.Parse(leerPirmeraLineea));

            Console.WriteLine($"El caracteres '{leerPirmeraLineea}' son: {totalRepetido}");
        }
    }
}
