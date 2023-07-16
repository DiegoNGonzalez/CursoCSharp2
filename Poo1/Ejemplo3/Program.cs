using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            nombre =Console.ReadLine();
            nombre = "Hola cómo estás?????" + nombre;
            //saber cantidad de caracteres
            int cant = nombre.Length;
            //poner todo en mayus
            nombre= nombre.ToUpper();
            //poner todo en minus
            //nombre.ToLower();
            //reemplazo de caracteres
            nombre = nombre.Replace('A', 'E');
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
