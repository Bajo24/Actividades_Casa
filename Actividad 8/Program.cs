using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_8
{
    class Program
    {
        static int SUMADIG(int numero)
        {
            int suma = 0;

            while (numero > 0)
            {
                suma = suma + numero % 10;
                numero = numero / 10;
            }

            return suma;
        }

        static void Main()
        {
            Random aleatorio = new Random();

            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = aleatorio.Next(1, 200);
            }

            Console.WriteLine("Numeros generados:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(numeros[i] + " ");
            }

            int divisibles = 0;

            for (int i = 0; i < 10; i++)
            {
                int suma = SUMADIG(numeros[i]);

                if (suma % 3 == 0)
                {
                    divisibles++;
                }
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("Cantidad de numeros divisibles entre 3: " + divisibles);
            Console.ReadKey();
        }
    }
}
