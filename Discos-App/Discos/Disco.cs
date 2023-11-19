using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Discos
{
    internal class Disco
    {
        public  int IdDisco { get; set; }
        public string NombreDisco { get; set; }
        public int CantidadCanciones { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string UrlImgTapa {  get; set; }
        public Estilo Estilo { get; set; }
        public TipoEdicion TipoEdicion { get; set; }

    }
}
