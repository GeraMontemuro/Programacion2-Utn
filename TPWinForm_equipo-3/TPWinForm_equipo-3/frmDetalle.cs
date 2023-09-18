using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_3
{
    public partial class frmDetalle : Form
    {
        private Articulo articulo = null;

        public frmDetalle()
        {
            InitializeComponent();
        }
        public frmDetalle(Articulo Articulo)
        {
            InitializeComponent();
            this.articulo = Articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            Console.WriteLine(articulo.IDArticulo);
            txtNombre.Text = articulo.Nombre;
            txtPrecio.Text = articulo.Precio.ToString();
            txtMarca.Text = articulo.Marca.ToString();
            txtCategoria.Text = articulo.Categoria.ToString();
            txtDescripcion.Text = articulo.Descripcion;
            pbxImagenes.Load(articulo.UrlImagen);
        }

    }   
}
