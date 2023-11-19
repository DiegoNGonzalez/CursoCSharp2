using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> Listar() {
            List<Pokemon> list = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta ("SELECT Numero,Nombre,p.Descripcion, UrlImagen, E.Tipo, D.Tipo Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE IdTipo=E.Id and D.id=p.IdDebilidad");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux= new Pokemon();
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImgUrl = (string)datos.Lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad= new Elemento();
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];

                    list.Add(aux); 
                }
               
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }


        }
        public void Agregar(Pokemon nuevo) { }

        public void Modificar(Pokemon modificado) { }
    }
}
