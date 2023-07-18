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
            Aguila a1 = new Aguila();

            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Tigre());
            animales.Add(new Gato());

            List<Flyable> listaVoladores= new List<Flyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Aguila());
            foreach (Flyable volardor in listaVoladores)
            {
                Console.WriteLine(volardor.Volar());
            }

            //Animal a1 = g1;

            //Gato g2 = (Gato)a1;
            //g2.Nombre = "blanquito";

            //Console.WriteLine(g1.Comunicarse());
            //Console.WriteLine(p1.Comunicarse());
            //Console.WriteLine(g2.Nombre);
            //foreach (Animal animal in animales)
            //{
            //    Console.WriteLine(animal.Comunicarse());
            //}
            Console.WriteLine(a1.Volar());
            Console.ReadKey();
        }
    }
}
