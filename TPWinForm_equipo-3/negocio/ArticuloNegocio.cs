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
                comando.CommandText = "SELECT Id,Nombre, Descripcion from Articulos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo Articulo = new Articulo();

                    Articulo.CodigoArticulo = (int)lector["Id"];
                    Articulo.Nombre = (string)lector["Nombre"];
                    Articulo.Descripcion = (string)lector["Descripcion"];

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
