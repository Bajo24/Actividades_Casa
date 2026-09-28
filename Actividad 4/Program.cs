using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el numero de alumnos: ");
            int n = int.Parse(Console.ReadLine());

            double[] notas = new double[n];

            double suma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());

                suma = suma + notas[i];
            }

            double mayor = notas[0];
            double menor = notas[0];

            for (int i = 1; i < n; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                }

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            double promedio = suma / n;

            Console.WriteLine("******************************************************");
            Console.WriteLine("Promedio de notas: " + promedio);
            Console.WriteLine("Nota maxima: " + mayor);
            Console.WriteLine("Nota minima: " + menor);
            Console.ReadKey();
        }
    }
}
