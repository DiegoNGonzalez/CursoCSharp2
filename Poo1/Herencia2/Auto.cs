using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Auto:Vehiculo 
    {
        public Auto() 
        { 
            Chasis = new Chasis();
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //composición relacion cercana define que el objeto debe nacer con esa condición
        public Chasis Chasis { get; }

        //agregación
        public Motor Motor { get; set; }
    }
}
