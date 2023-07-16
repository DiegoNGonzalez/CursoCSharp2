using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        public Botella(string color, string material) 
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        //sobrecargar el constructor
        public Botella() { }

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;
        public string Material
        {
            get { return material; }
        }
        public string Color
        {
            get { return color; }
        }
        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        //PROPIEDADES 
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set { capacidad = value; }
        //}
        //Método
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                float monto = (dif * 50) / 100;
                cantidadActual += dif;
                return monto;
            }
            else
            {
                cantidadActual = 100;
                return 50;
            }
        }
    }
}
