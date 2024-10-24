using System;

namespace EjercicioArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int size = 0;
            do
            {
                Console.WriteLine("Introduce el tamaño del array:");
                size = int.Parse(Console.ReadLine());

                if(size <= 0)
                    Console.WriteLine("Por favor, introduce un número válido mayor que 0.");

            } while (size <= 0);
           
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Introduce un valor para añadir al array:");
                array[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
            }

            double media = (double)suma / size;

            Console.WriteLine($"La suma de los valores es: {suma}");
            Console.WriteLine($"La media de los valores es: {media}");
        }
    }
}
