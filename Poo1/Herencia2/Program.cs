using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto >AutoDeportivo > AutoUrbano
            //Camioneta > Camioneta4x4 >CamionetaUtilitaria
            //Moto >MotoDePïsta > MotoEnduro >MotoDeCalle
            Vehiculo v1 = new Vehiculo();
            Camioneta c1= new Camioneta();
            v1.Motor = 1000;

            c1.CargaMaxima=1.1F;

            Vehiculo v2 = new Camioneta();//una camioneta es un vehiculo por herencia
            Camioneta c2 = new Camioneta();
            c2.Color = "Rojo";
            Camioneta c3 = new Camioneta();
            c3.Color = "Azul";
            Vehiculo v3 = new AutoDeportivo(); // si es vehiculo
            c1.Color = "Amarillo";

            List<Camioneta> listaCamionetas= new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //Console.WriteLine("La cantidad de camionetas es: "+listaCamionetas.Count);
            ////listaCamionetas[1].Color = "Negro";
            //c2.Color = "Verde";
            //Console.WriteLine("El color es "+ listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas es: " + listaCamionetas.Count);
            foreach (Camioneta item  in listaCamionetas)
            {
                Console.WriteLine("Color: " + item.Color);
            }


            Console.ReadKey();

        }
    }
}
