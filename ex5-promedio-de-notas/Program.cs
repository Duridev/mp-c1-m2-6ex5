using System;
using System.Globalization;
using System.Threading;

namespace ex5_promedio_de_notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            float nota1, nota2, nota3, promedio;

            Console.WriteLine("Escribe tu primera nota:");
            nota1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Escribe tu segunda nota:");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escribe tu tercera nota:");
            nota3 = float.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"El promedio final es: {promedio:F1}");
        }
    }
}
