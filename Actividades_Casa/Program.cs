using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    class Program
    {
        static void Main()
        {
            double[] notas = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese la nota " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            double menor = notas[0];

            for (int i = 1; i < 6; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                }
            }

            double suma = 0;
            bool eliminado = false;

            for (int i = 0; i < 6; i++)
            {
                if (notas[i] == menor && eliminado == false)
                {
                    eliminado = true;
                }
                else
                {
                    suma = suma + notas[i];
                }
            }

            double promedio = suma / 5;

            Console.WriteLine("******************************************************");
            Console.WriteLine("Nota eliminada: " + menor);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}