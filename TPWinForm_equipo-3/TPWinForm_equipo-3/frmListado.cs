using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

            CategoriaNegocio cate = new CategoriaNegocio();
            MarcaNegocio marc = new MarcaNegocio();

            cbbFiltroCategoria.DataSource = cate.listar();
            cbbFiltroCategoria.ValueMember = "Id";
            cbbFiltroCategoria.DisplayMember = "Descripcion";

            cbbFiltroMarca.DataSource = marc.listar();
            cbbFiltroMarca.ValueMember = "Id";
            cbbFiltroMarca.DisplayMember = "Descripcion";

        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulo.CurrentRow != null)
            {
                Articulo aux = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                mostrarImagen(aux.UrlImagen);
            }
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
            ocultarColumnas();
            mostrarImagen(ListArticulo[0].UrlImagen);
        }

        private void ocultarColumnas()
        {
            dgvArticulo.Columns["UrlImagen"].Visible = false;
            dgvArticulo.Columns["IdArticulo"].Visible = false;

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
                    artNegocio.Eliminar(seleccionado.IDArticulo);
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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBusqueda.Text;

            if(filtro != "")
            {
                listaFiltrada = ListArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListArticulo;
            }


            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
           
            ArticuloNegocio articulofiltrado = new ArticuloNegocio();
            try
              {
                string filtroMarca = cbbFiltroMarca.SelectedItem.ToString();
                string filtroCategoria = cbbFiltroCategoria.SelectedItem.ToString();
                dgvArticulo.DataSource = null;
                dgvArticulo.DataSource=articulofiltrado.Busqueda(filtroMarca, filtroCategoria);
                ocultarColumnas();
                
              }
              catch (Exception ex)
              {
                  throw ex;
              }
        }

        private void btndetalle_Click(object sender, EventArgs e)
        {
            Articulo ArticuloSeleccionado = new Articulo();
            ArticuloSeleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            frmDetalle detalle = new frmDetalle(ArticuloSeleccionado);
            detalle.ShowDialog();

            


        }
    }


}
