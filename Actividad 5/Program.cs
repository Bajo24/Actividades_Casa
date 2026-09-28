using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Ingrese el numero de alumnos: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 40)
            {
                Console.WriteLine("El numero maximo de alumnos es 40.");
                return;
            }

            int[] notas = new int[n];

            int ceros = 0;
            int veintes = 0;
            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese la nota del alumno " + (i + 1) + ": ");
                notas[i] = int.Parse(Console.ReadLine());

                if (notas[i] == 0)
                {
                    ceros++;
                }

                if (notas[i] == 20)
                {
                    veintes++;
                }

                if (notas[i] >= 13)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("Cantidad de notas 00: " + ceros);
            Console.WriteLine("Cantidad de notas 20: " + veintes);
            Console.WriteLine("Cantidad de aprobados: " + aprobados);
            Console.WriteLine("Cantidad de desaprobados: " + desaprobados);
            Console.ReadKey();
        }
    }
}
