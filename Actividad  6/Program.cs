using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_6
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();

            Console.Write("Ingrese el numero de personas: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 200)
            {
                Console.WriteLine("El numero maximo es 200.");
                return;
            }

            int[] montos = new int[n];

            for (int i = 0; i < n; i++)
            {
                montos[i] = aleatorio.Next(25, 501);
            }

            Console.WriteLine("Montos generados:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(montos[i] + " ");
            }

            Array.Sort(montos);

            Console.WriteLine();
            Console.WriteLine("Montos ordenados:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(montos[i] + " ");
            }

            int Intervalo = 0;
            int impares = 0;

            for (int i = 0; i < n; i++)
            {
                if (montos[i] >= 100 && montos[i] <= 300)
                {
                    Intervalo++;
                }

                if (montos[i] % 2 != 0)
                {
                    impares++;
                }
            }

            Console.WriteLine("\n******************************************************");
            Console.WriteLine("Personas que gastaron entre 100 y 300 soles: " + Intervalo);
            Console.WriteLine("Cantidad de montos impares: " + impares);
            Console.ReadKey();
        }
    }
}
