using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Data;

namespace negocio
{
    public class ArticuloNegocio
    {
       
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security = true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Art.Id,Art.Nombre,Art.Descripcion, Ima.ImagenUrl  from Articulos Art\r\ninner join IMAGENES Ima ON Art.Id=Ima.Id\r\n";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo Articulo = new Articulo();

                    Articulo.CodigoArticulo = (int)lector["Id"];
                    Articulo.Nombre = (string)lector["Nombre"];
                    Articulo.Descripcion = (string)lector["Descripcion"];
                    Articulo.UrlImagen = (string)lector["ImagenUrl"];

                    lista.Add(Articulo);
                }
                conexion.Close();

            return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
