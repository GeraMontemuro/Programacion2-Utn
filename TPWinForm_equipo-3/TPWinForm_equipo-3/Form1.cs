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
    public partial class Form1 : Form
    {
        private List<Articulo> ListArticulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio Art= new ArticuloNegocio();
            ListArticulo = Art.listar();
            dgvArticulo.DataSource = ListArticulo;
            pbxArticulo.Load(ListArticulo[0].UrlImagen);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo aux = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            pbxArticulo.Load(aux.UrlImagen);
        }
    }
}
