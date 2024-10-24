using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        public static int ContarEspacios(string text)
        {
            int counter = 0;

            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c))
                    counter++;
            }

            return counter; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una cadena de texto:");
            string entry = Console.ReadLine();

            int numeroDeEspacios = ContarEspacios(entry);

            Console.WriteLine($"El número de espacios en blanco es: {numeroDeEspacios}");
        }
    }
    

}
