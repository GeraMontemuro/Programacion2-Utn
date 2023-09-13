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
    public partial class FrmAgregarArticulo : Form
    {
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Articulo aux = new Articulo();
            ArticuloNegocio auxnegocio = new ArticuloNegocio();

            try
            {
                aux.CodigoArticulo = txtCodigo.Text;
                aux.Nombre = txtNombre.Text;
                aux.Descripcion = txtDescripcion.Text;
                //aux.Marca= txt....
                //aux.CAtegoria = txt...
                //aux.UrlImagen = 
                //aux.Precio = (float)txtPrecio.Text;

                 auxnegocio.cargar(aux);
                MessageBox.Show("Articulo agregado");
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.ToString())
            }


        }
    }
}
