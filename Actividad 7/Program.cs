using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el numero de alumnos: ");
            int n = int.Parse(Console.ReadLine());

            int[] notas = new int[n];
            int[] frecuencia = new int[21];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = int.Parse(Console.ReadLine());

                frecuencia[notas[i]]++;
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("Frecuencia de las notas:");

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Puntuacion [" + i + "]: " + frecuencia[i]);
            }

            int mayorFrecuencia = frecuencia[0];

            for (int i = 1; i <= 20; i++)
            {
                if (frecuencia[i] > mayorFrecuencia)
                {
                    mayorFrecuencia = frecuencia[i];
                }
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("Nota o notas que mas se repiten:");

            for (int i = 0; i <= 20; i++)
            {
                if (frecuencia[i] == mayorFrecuencia)
                {
                    Console.WriteLine("Nota [" + i + "]: " + frecuencia[i] + " veces");
                }
            }
            Console.ReadKey();
        }
    }
}
