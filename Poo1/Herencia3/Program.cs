using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato g1= new Gato();
            g1.Nombre = "Javier";

            Perro p1= new Perro();
            p1.Nombre = "Roberto";

            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Tigre());
            animales.Add(new Gato());

            //Animal a1 = g1;

            //Gato g2 = (Gato)a1;
            //g2.Nombre = "blanquito";

            //Console.WriteLine(g1.Comunicarse());
            //Console.WriteLine(p1.Comunicarse());
            //Console.WriteLine(g2.Nombre);
            foreach (Animal animal in animales)
            {
                Console.WriteLine(animal.Comunicarse());
            }
            Console.ReadKey();
        }
    }
}
