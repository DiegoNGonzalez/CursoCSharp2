using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    
    public class DiscoNegocio
    {
        public List<Disco> Listar()
        {
            List<Disco> lista= new List<Disco>();
            AccesoDatos datos= new AccesoDatos();



            try
            {
                datos.SetConsulta("select titulo, CantidadCanciones, d.Id, FechaLanzamiento, UrlImagenTapa, t.Descripcion Edicion, e.Descripcion Estilo from DISCOS d, TIPOSEDICION t, ESTILOS e where d.IdEstilo=e.Id and d.IdTipoEdicion= t.id;");
                datos.EjecutarLectura();

                while(datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.NombreDisco =(string) datos.Lector["Titulo"];
                    aux.CantidadCanciones = datos.Lector.GetInt32(1);
                    aux.IdDisco = (int)datos.Lector["Id"];
                    if (!(datos.Lector["FechaLanzamiento"] is DBNull))
                        aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.UrlImgTapa = (string)datos.Lector["UrlImagenTapa"];
                    aux.estilo = new Estilo();
                    aux.estilo.Descripcion = (string)datos.Lector["Estilo"];
                    aux.tipoEdicion=new TipoEdicion();
                    aux.tipoEdicion.Descripcion = (string)datos.Lector["Edicion"];

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
        public void AgregarDisco(Disco nuevo)
        {
            AccesoDatos datos= new AccesoDatos();
            try
            {
                datos.SetConsulta("insert into DISCOS (Titulo,FechaLanzamiento,CantidadCanciones,UrlImagenTapa,IdEstilo,IdTipoEdicion) values('"+nuevo.NombreDisco+"',@FechaLanzamiento,@CantidadCanciones,'"+nuevo.UrlImgTapa+"',@IdEstilo,@IdTipoEdicion);");
                //datos.SetParametros("@Titulo", nuevo.NombreDisco);
                datos.SetParametros("@FechaLanzamiento", nuevo.FechaLanzamiento.ToShortTimeString());
                //datos.SetParametros("@FechaLanzamiento", nuevo.FechaLanzamiento.ToString("yyyy-MM-dd"));
                ////datos.SetParametros("@año", nuevo.FechaLanzamiento.Year);
                ////datos.SetParametros("@mes",nuevo.FechaLanzamiento.Month);
                ////datos.SetParametros("@dia",nuevo.FechaLanzamiento.Day);
                datos.SetParametros("@CantidadCanciones",nuevo.CantidadCanciones);
                //datos.SetParametros("@UrlImagenTapa", nuevo.UrlImgTapa);
                datos.SetParametros("@IdEstilo",nuevo.estilo.IdEstilo);
                datos.SetParametros("@IdTipoEdicion", nuevo.tipoEdicion.IdTipoEdicion);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
    }
}
