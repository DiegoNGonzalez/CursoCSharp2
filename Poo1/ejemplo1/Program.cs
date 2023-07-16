using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //float sueldo;
            //string nombre;

            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            Persona p1 = new Persona("Diego");


            Console.WriteLine(p1.saludar());
            p1.setEdad(30);
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());
            Console.WriteLine(p1.saludar("Maxi"));

            Botella b1 = new Botella("Rojo", "Plastico");
            //b1.Capacidad = 200;
            Console.WriteLine("La capacidad es " + b1.Capacidad);
            Console.WriteLine("la cantidad actual es: "+b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar la cantidad actual es: " + b1.CantidadActual);
            b1.recargar();
            Console.WriteLine("Luego de recargar la cantidad actual es: " + b1.CantidadActual);

            Console.WriteLine("El color es " + b1.Color);




            Console.ReadKey();
        }

    }
}
