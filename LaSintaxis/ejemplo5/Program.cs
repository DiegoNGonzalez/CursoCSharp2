using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 50;
            //funciones
            Console.WriteLine(saludar("maxi"));
            Console.WriteLine(sumar(10,ref b));
            Console.ReadKey (); 

        }
        static int sumar(int a, ref int b)
        {
            return a + b;
        }

        static string saludar(string nombre)
        {
            return "hola " + nombre;
        }

    }
}
