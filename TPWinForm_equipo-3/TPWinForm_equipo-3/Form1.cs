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
            ArticuloNegocio Art = new ArticuloNegocio();
            ListArticulo = Art.listar();
            dgvArticulo.DataSource = ListArticulo;
            CambiarImagen(ListArticulo[0].UrlImagen);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo aux = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            CambiarImagen(aux.UrlImagen);
        }

        private void CambiarImagen(string imagen)
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
        }
    }


}
