using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Discos
{
    
    internal class DiscoNegocio
    {
        public List<Disco> Listar()
        {
            List<Disco> lista= new List<Disco>();
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                Conexion.ConnectionString = "server=DIEGONZALEZDEV\\SQLEXPRESS; database=DISCOS_DB; integrated security=true;";
                Comando.CommandType= System.Data.CommandType.Text;
                Comando.CommandText = "select titulo, CantidadCanciones, d.Id, FechaLanzamiento, UrlImagenTapa, t.Descripcion Edicion, e.Descripcion Estilo from DISCOS d, TIPOSEDICION t, ESTILOS e where d.IdEstilo=e.Id and d.IdTipoEdicion= t.id;";
                Comando.Connection = Conexion;
                Conexion.Open();
                lector= Comando.ExecuteReader();

                while(lector.Read())
                {
                    Disco aux = new Disco();
                    aux.NombreDisco =(string) lector["Titulo"];
                    aux.CantidadCanciones = lector.GetInt32(1);
                    aux.IdDisco = (int)lector["Id"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.UrlImgTapa = (string)lector["UrlImagenTapa"];
                    aux.Estilo = new Estilo();
                    aux.Estilo.Descripcion = (string)lector["Estilo"];
                    aux.TipoEdicion=new TipoEdicion();
                    aux.TipoEdicion.Descripcion = (string)lector["Edicion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { Conexion.Close(); }
        }
    }
}
