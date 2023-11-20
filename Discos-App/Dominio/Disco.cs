using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dominio 
{ 
    public class Disco
    {
        public  int IdDisco { get; set; }
        [DisplayName("Nombre Disco")]
        public string NombreDisco { get; set; }
        [DisplayName("Cantidad de Canciones")]
        public int CantidadCanciones { get; set; }
        [DisplayName("Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        public string UrlImgTapa {  get; set; }
        [DisplayName("Estilo")]
        public Estilo estilo { get; set; }

        [DisplayName("Tipo de Edición")]
        public TipoEdicion tipoEdicion { get; set; }

    }
}
