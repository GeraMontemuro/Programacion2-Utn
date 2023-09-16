using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
                aux.Marca = (Marca)cboMarca.SelectedItem;
                aux.Categoria = (Categoria)cboCategoria.SelectedItem;
                aux.UrlImagen = txtUrlImagen.Text;
                aux.Precio = SqlMoney.Parse(txtPrecio.Text);

                
                auxnegocio.cargar(aux);
                MessageBox.Show("Articulo agregado");
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio Cate = new CategoriaNegocio();
            MarcaNegocio Marc = new MarcaNegocio();
            try
            {
                cboCategoria.DataSource = Cate.listar(); 
                cboMarca.DataSource = Marc.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarImagen.Load(imagen);
            }
            catch (Exception)
            {
                pbxAgregarImagen.Load("https://production.listennotes.com/podcasts/el-podcast-m%C3%A1s-random-del-mundo-L6I3Ep9lRTB-xB_PCg0EDch.1400x1400.jpg");
            }
        }
    }
}
