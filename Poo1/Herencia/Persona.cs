using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Persona
    {
        //abstract no puede ser instanciada
        //sealed no puede ser heredada
        //static una clase que no se puede instanciar pero si usar


        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }
    }
}
