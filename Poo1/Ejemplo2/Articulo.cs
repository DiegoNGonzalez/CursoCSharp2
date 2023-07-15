using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Articulo
    {
        //private int codArticulo;
        public int CodigoArticulo { get; set; }

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodMarca
        {
            get { return codMarca; }
            set 
            { 
                if(value >0 && value <11)
                    codMarca = value;
                else
                    codMarca = -1;

            }
        }



    }
}
