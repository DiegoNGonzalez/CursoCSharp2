using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> Listar()
        {
            List<Estilo> lista= new List<Estilo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("SELECT Id, Descripcion FROM ESTILOS;");
                datos.EjecutarLectura();
                while(datos.Lector.Read())
                {
                    Estilo aux= new Estilo();
                    aux.IdEstilo = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
    }
}
