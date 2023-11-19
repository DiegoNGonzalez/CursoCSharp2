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
            SqlConnection conexcion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexcion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true; ";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Numero,Nombre,p.Descripcion, UrlImagen, E.Tipo, D.Tipo Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE IdTipo=E.Id and D.id=p.IdDebilidad";
                comando.Connection = conexcion;
                conexcion.Open();
                lector=comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux= new Pokemon();
                    aux.Numero = lector.GetInt32(0);
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImgUrl = (string)lector["UrlImagen"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.Descripcion = (string)lector["Tipo"];
                    aux.Debilidad= new Elemento();
                    aux.Debilidad.Descripcion = (string)lector["Debilidad"];

                    list.Add(aux); 
                }
               
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexcion.Close(); }


        }
        public void Agregar(Pokemon nuevo) { }

        public void Modificar(Pokemon modificado) { }
    }
}
