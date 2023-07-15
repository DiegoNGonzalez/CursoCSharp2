using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicionales
            //if
            //switch

            int a = 10, b = 12;
            //== != < > >= <=
            // && ||

            if (a == b && b!=10 || !(a==20))
            {
                //todo lo que necesite
                Console.WriteLine("verdarero");
            }
            else
            {
                Console.WriteLine("falso");

            }

            switch (a)
            {
                case 1:
                    //instruciones
                    break;
                case 2:
                    //instrucciones
                    break;
                default:
                    //instrucciones
            }

            Console.ReadKey();
        }
    }
}
