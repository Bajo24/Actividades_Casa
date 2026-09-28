using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Program
    {
        static void Main()
        {
            double[] pesos = new double[10];

            double suma = 0;
            double mayor = 0;

            int delgados = 0;
            int medianos = 0;
            int gruesos = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el peso del cliente " + (i + 1) + ": ");
                pesos[i] = double.Parse(Console.ReadLine());

                suma = suma + pesos[i];

                if (pesos[i] > mayor)
                {
                    mayor = pesos[i];
                }

                if (pesos[i] < 53)
                {
                    delgados++;
                }
                else if (pesos[i] <= 60)
                {
                    medianos++;
                }
                else
                {
                    gruesos++;
                }
            }

            double promedio = suma / 10;

            Console.WriteLine("******************************************************");
            Console.WriteLine("Peso promedio: " + promedio);
            Console.WriteLine("Mayor peso: " + mayor);
            Console.WriteLine("Personas delgadas: " + delgados);
            Console.WriteLine("Personas medianas: " + medianos);
            Console.WriteLine("Personas gruesas: " + gruesos);
            Console.ReadKey();
        }
    }
}