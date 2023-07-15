using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //persona: Edad, Sueldo, Nombre
        //atributos o miembros(donde va la información)
        private int edad;
        private float sueldo;
        private string nombre;
        //modificadores de visibilidad palabras reservadas
        //publico(con acceso) privado(sin acceso)
        
        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }
    }
}
