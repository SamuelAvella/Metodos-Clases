using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        public static long CalcFactorial(int x)
        {
            if(x == 1)
            {
                return 1;
            } else
            {
                return x * CalcFactorial(x - 1);
            }
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para ver su factorial");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"El factorial de {x} es {CalcFactorial(x)}");
        }
    }
}
