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
        private Articulo articulo = null;
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        public FrmAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
   
            ArticuloNegocio auxnegocio = new ArticuloNegocio();
            Imagen ImagenCargada = new Imagen();

            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                ImagenCargada.ImagenUrl= txtUrlImagen.Text;

                if (articulo.IDArticulo != 0)
                {
                    auxnegocio.Modificar(articulo,ImagenCargada);
                    MessageBox.Show("Artículo modificado");
                }
                else
                {
                auxnegocio.cargar(articulo);
                MessageBox.Show("Artículo agregado");

                }

                
                Close();
                
            }
            catch  (FormatException ex)
            {
                MessageBox.Show("Ingresa un precio en números por favor");
            }

            catch (OverflowException ex) 
            {                          
                MessageBox.Show("Superaste la cantidad de caracteres");                
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
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboMarca.DataSource = Marc.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";


                if (articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                }
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
