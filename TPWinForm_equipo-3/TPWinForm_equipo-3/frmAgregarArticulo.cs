﻿using dominio;
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
    }
}