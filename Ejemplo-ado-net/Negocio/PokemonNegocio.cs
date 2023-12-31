﻿using System;
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
        private AccesoDatos datos;
        public PokemonNegocio()
        {
            datos = new AccesoDatos();
        }
        public List<Pokemon> Listar() {
            List<Pokemon> list = new List<Pokemon>();

            try
            {
                datos.SetearConsulta ("SELECT Numero,Nombre,p.Descripcion, UrlImagen, E.Tipo, D.Tipo Debilidad, P.IdTipo, P.IdDebilidad, P.Id, Activo from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE IdTipo=E.Id and D.id=p.IdDebilidad");
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux= new Pokemon();
                    aux.Id=(int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagen"))))
                    //    aux.ImgUrl = (string)datos.Lector["UrlImagen"];
                    //if (!(datos.Lector["UrlImagen"]is DBNull))
                    aux.ImgUrl = (string)datos.Lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad= new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    aux.Estado = (bool)datos.Lector["Activo"];
                    if (aux.Estado)
                    {
                        list.Add(aux); 

                    }
                }
               
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }


        }
        public void Agregar(Pokemon nuevo)
        {
            try
            {
                datos.SetearConsulta("insert into POKEMONS (Numero,Nombre,Descripcion,UrlImagen,Activo,IdTipo,IdDebilidad ) values(" + nuevo.Numero+",'"+nuevo.Nombre+"','"+nuevo.Descripcion+"','"+nuevo.ImgUrl+"',1,@idTipo,@idDebilidad)");
                datos.SetearParametro("@idTipo", nuevo.Tipo.Id);
                datos.SetearParametro("@idDebilidad", nuevo.Debilidad.Id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }

        public void Modificar(Pokemon modificado) 
        { 
            try
            {
                datos.SetearConsulta("UPDATE POKEMONS set Numero=@numero, Nombre=@nombre,Descripcion=@descripcion, UrlImagen=@urlImagen,IdTipo=@idTipo,IdDebilidad=@idDebilidad WHERE id=@Id");
                datos.SetearParametro("@numero", modificado.Numero);
                datos.SetearParametro("@nombre", modificado.Nombre);
                datos.SetearParametro("@descripcion", modificado.Descripcion);
                datos.SetearParametro("@urlImagen", modificado.ImgUrl);
                datos.SetearParametro("@idTipo", modificado.Tipo.Id);
                datos.SetearParametro("@idDebilidad", modificado.Debilidad.Id);
                datos.SetearParametro("@Id", modificado.Id);

                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }
        public void Eliminar(int id)
        {
            try
            {
                datos.SetearConsulta("delete from POKEMONS where id=@id");
                datos.SetearParametro("@id", id);
                datos.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally{  datos.CerrarConexion();}
        }
        public void EliminarLogico(int id)
        {
            try
            {
                datos.SetearConsulta("UPDATE POKEMONS set Activo=0 WHERE id=@id");
                datos.SetearParametro("id", id);
                datos.EjecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.CerrarConexion(); }
        }

        public List<Pokemon> Filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            try
            {
                string consulta = "SELECT Numero,Nombre,p.Descripcion, UrlImagen, E.Tipo, D.Tipo Debilidad, P.IdTipo, P.IdDebilidad, P.Id, Activo from POKEMONS P, ELEMENTOS E, ELEMENTOS D WHERE IdTipo=E.Id and D.id=p.IdDebilidad AND ";
                if (campo == "Numero")
                {
                    if(criterio=="Mayor a ")
                    {
                        consulta += "Numero >" + filtro;
                    }else if(criterio=="Menor a ")
                    {
                        consulta += "Numero <" + filtro;
                    }
                    else
                    {
                        consulta += "Numero = " + filtro;
                    }
                }else if(campo == "Nombre")
                {
                    if(criterio=="Comienza con ")
                    {
                        consulta += "Nombre like '" + filtro + "%'";
                    }else if (criterio=="Termina con ")
                    {
                        consulta += "Nombre like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta+= "Nombre like '%"+filtro+"%'";
                    }
                }
                else
                {
                    if (criterio == "Comienza con ")
                    {
                        consulta += "P.Descripcion like '" + filtro + "%'";
                    }
                    else if (criterio == "Termina con ")
                    {
                        consulta += "P.Descripcion like '%" + filtro + "'";
                    }
                    else
                    {
                        consulta += "P.Descripcion like '%" + filtro + "%'";
                    }
                }
                
                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = datos.Lector.GetInt32(0);
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    //if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagen"))))
                    //    aux.ImgUrl = (string)datos.Lector["UrlImagen"];
                    //if (!(datos.Lector["UrlImagen"]is DBNull))
                    aux.ImgUrl = (string)datos.Lector["UrlImagen"];

                    aux.Tipo = new Elemento();
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    aux.Estado = (bool)datos.Lector["Activo"];
                    if (aux.Estado)
                    {
                        lista.Add(aux);

                    }
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
