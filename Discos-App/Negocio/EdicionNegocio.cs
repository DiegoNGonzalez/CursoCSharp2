using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EdicionNegocio
    {
        public List<TipoEdicion> Listar()
        {
            List<TipoEdicion> lista = new List<TipoEdicion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetConsulta("SELECT Id, Descripcion FROM TIPOSEDICION;");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();
                    aux.IdTipoEdicion = (int)datos.Lector["Id"];
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
