using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace TPWinForm_equipo_3
{
    public partial class frmListado : Form
    {
        private List<Articulo> ListArticulo;
        public frmListado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo aux = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            mostrarImagen(aux.UrlImagen);
        }

        private void mostrarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://production.listennotes.com/podcasts/el-podcast-m%C3%A1s-random-del-mundo-L6I3Ep9lRTB-xB_PCg0EDch.1400x1400.jpg");
            }
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo ventana = new FrmAgregarArticulo();
            ventana.ShowDialog();
            mostrar();
        }

        public void mostrar()
        {
            ArticuloNegocio Art = new ArticuloNegocio();
            ListArticulo = Art.listar();
            dgvArticulo.DataSource = ListArticulo;
            dgvArticulo.Columns["UrlImagen"].Visible = false;
            dgvArticulo.Columns["IdArticulo"].Visible = false;
            mostrarImagen(ListArticulo[0].UrlImagen);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el registro?", "Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    artNegocio.eliminar(seleccionado.IDArticulo);
                    mostrar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo ArticuloSeleccionado;
            ArticuloSeleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            FrmAgregarArticulo modificar = new FrmAgregarArticulo(ArticuloSeleccionado);
            modificar.ShowDialog();
            mostrar();
            
        }
    }


}
