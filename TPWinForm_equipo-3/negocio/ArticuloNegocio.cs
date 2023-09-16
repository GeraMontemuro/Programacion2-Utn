using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Data;
using System.Reflection;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;

namespace negocio
{
    public class ArticuloNegocio
    {    

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("SELECT Art.Id AS Id, Art.Codigo, Art.Nombre, Art.Descripcion, MIN(Ima.ImagenUrl) AS ImagenUrl,Mar.Descripcion AS 'Marca' ,Cat.Descripcion AS 'Categoria' FROM ARTICULOS Art \r\nLEFT JOIN IMAGENES Ima ON Art.Id = Ima.IdArticulo\r\nLEFT JOIN MARCAS Mar ON Art.IdMarca=Mar.Id\r\nLEFT JOIN CATEGORIAS Cat ON Art.IdCategoria=Cat.Id\r\nGROUP BY Art.Id, Art.Codigo, Art.Nombre, Art.Descripcion,Mar.Descripcion,Cat.Descripcion");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo Articulo = new Articulo();

                    Articulo.IDArticulo = (int)datos.Lector["Id"];
                    Articulo.CodigoArticulo = (string)datos.Lector["Codigo"];
                    Articulo.Nombre = (string)datos.Lector["Nombre"];
                    Articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))///ver crear helper para todas los null
                    {
                        Articulo.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    Articulo.Marca = new Marca();
                    Articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    Articulo.Categoria = new Categoria();
                    if (!(datos.Lector["Categoria"] is DBNull))///ver crear helper para todas los null
                    {
                        Articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    }
                    else { Articulo.Categoria.Descripcion = "No tiene"; }

                    lista.Add(Articulo);
                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void cargar(Articulo nuevo)
        {
            AccesoDatos dato = new AccesoDatos();
            AccesoDatos datoimagen = new AccesoDatos();
            List<Articulo> listaArticuloAgregado = new List<Articulo>();
            Imagen imagenCargada = new Imagen();

            try
            {
                dato.setearConsulta("Insert Into Articulos(Codigo,Nombre,Descripcion,IdMarca,IdCategoria) values ('" + nuevo.CodigoArticulo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "',@IdMarca,@IdCategoria)");
                dato.setearParametro("@IdMarca", nuevo.Marca.Id);
                dato.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                dato.ejecutarAccion();

                
                listaArticuloAgregado = listar();
           
                foreach (Articulo item in listaArticuloAgregado)
                {
                    imagenCargada.IDArticulo = item.IDArticulo;
                    Console.WriteLine("ARTICULO CARGADO: " + imagenCargada.IDArticulo);
                }

                datoimagen.setearConsulta("insert into IMAGENES (IdArticulo,ImagenUrl)values(@IdArticulo,@ImagenUrl)");
                datoimagen.setearParametro("@IdArticulo", imagenCargada.IDArticulo);
                datoimagen.setearParametro("@ImagenUrl", nuevo.UrlImagen);
                datoimagen.ejecutarAccion();
                Console.WriteLine("Consulta SQL para la Imagen: " + imagenCargada.IDArticulo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
                datoimagen.cerrarConexion();
                
            }
          
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos dato = new AccesoDatos();
                AccesoDatos datoimagen = new AccesoDatos();
                dato.setearConsulta("delete from articulos where id = @id");
                dato.setearParametro("@id", id);
                dato.ejecutarAccion();
                datoimagen.setearConsulta("delete from imagenes where IdArticulo = @id");
                datoimagen.setearParametro("@id", id);
                datoimagen.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
