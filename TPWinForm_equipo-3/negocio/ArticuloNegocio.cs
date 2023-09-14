using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Data;
using System.Reflection;

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

                datos.setearConsulta("SELECT Art.Id AS Id, Art.Codigo, Art.Nombre, Art.Descripcion, MIN(Ima.ImagenUrl) AS ImagenUrl FROM ARTICULOS Art INNER JOIN IMAGENES Ima ON Art.Id = Ima.IdArticulo GROUP BY Art.Id, Art.Codigo, Art.Nombre, Art.Descripcion");

                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo Articulo = new Articulo();

                    Articulo.CodigoArticulo = (string)datos.Lector["Codigo"];
                    Articulo.Nombre = (string)datos.Lector["Nombre"];
                    Articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    Articulo.UrlImagen = (string)datos.Lector["ImagenUrl"];

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

            try
            {
                dato.setearConsulta("Insert Into Articulos(Codigo,Nombre,Descripcion) values (" + nuevo.CodigoArticulo + ",'" + nuevo.Nombre + "','" + nuevo.Descripcion + "')");
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
    }
}
