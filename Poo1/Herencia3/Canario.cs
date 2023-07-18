using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Canario : AnimalDomestico, Flyable
    {
        public override string Comunicarse()
        {
            return "pio pio";
        }

        public string Volar()
        {
            return "vuela como un canario...";
        }
    }
}
