using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();

            Console.Write("Ingrese el numero de personas: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 100)
            {
                Console.WriteLine("El numero maximo es 100.");
                return;
            }

            int[] edades = new int[n];

            for (int i = 0; i < n; i++)
            {
                edades[i] = aleatorio.Next(1, 101);
            }

            Console.WriteLine("Edades generadas:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Posicion " + i + ": " + edades[i]);
            }

            int menor = edades[0];
            int posicion = 0;

            for (int i = 1; i < n; i++)
            {
                if (edades[i] < menor)
                {
                    menor = edades[i];
                    posicion = i;
                }
            }

            int cantidad = 0;

            for (int i = 0; i < n; i++)
            {
                if (edades[i] >= 30 && edades[i] <= 50)
                {
                    cantidad++;
                }
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("Menor edad: " + menor);
            Console.WriteLine("Posicion de la menor edad: " + posicion);
            Console.WriteLine("Personas entre 30 y 50 años: " + cantidad);

            Console.Write("Ingrese una edad a buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < n; i++)
            {
                if (edades[i] == buscar)
                {
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("La edad se encuentra en el arreglo.");
            }
            else
            {
                Console.WriteLine("La edad no se encuentra en el arreglo.");
            }
            Console.ReadKey();
        }
    }
}
