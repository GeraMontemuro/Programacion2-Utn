namespace TPWinForm_equipo_3
{
    partial class frmListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListado));
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblopcion = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblcategorias = new System.Windows.Forms.Label();
            this.btndetalle = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cbbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.cbbFiltroMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(18, 112);
            this.dgvArticulo.MultiSelect = false;
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(485, 213);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(525, 92);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(198, 233);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // lblopcion
            // 
            this.lblopcion.AutoSize = true;
            this.lblopcion.Location = new System.Drawing.Point(15, 350);
            this.lblopcion.Name = "lblopcion";
            this.lblopcion.Size = new System.Drawing.Size(82, 13);
            this.lblopcion.TabIndex = 6;
            this.lblopcion.Text = "Elija una opción";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBusqueda.BackgroundImage")));
            this.btnBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusqueda.Location = new System.Drawing.Point(421, 22);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(33, 30);
            this.btnBusqueda.TabIndex = 8;
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(58, 28);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(344, 20);
            this.txtBusqueda.TabIndex = 9;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(222, 60);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(42, 13);
            this.lblMarcas.TabIndex = 13;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblcategorias
            // 
            this.lblcategorias.AutoSize = true;
            this.lblcategorias.Location = new System.Drawing.Point(66, 60);
            this.lblcategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcategorias.Name = "lblcategorias";
            this.lblcategorias.Size = new System.Drawing.Size(59, 13);
            this.lblcategorias.TabIndex = 12;
            this.lblcategorias.Text = "Categorías";
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(525, 329);
            this.btndetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(198, 28);
            this.btndetalle.TabIndex = 12;
            this.btndetalle.Text = "Listar Detalle";
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.btndetalle_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(18, 374);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(94, 24);
            this.btnAgregarArticulo.TabIndex = 13;
            this.btnAgregarArticulo.Text = "Agregar Artículo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(144, 375);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(107, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar Artículo";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(288, 375);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 24);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar Artículo";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(364, 74);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(130, 24);
            this.btnFiltro.TabIndex = 16;
            this.btnFiltro.Text = "Busqueda Avanzada";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // cbbFiltroCategoria
            // 
            this.cbbFiltroCategoria.FormattingEnabled = true;
            this.cbbFiltroCategoria.Location = new System.Drawing.Point(68, 79);
            this.cbbFiltroCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFiltroCategoria.Name = "cbbFiltroCategoria";
            this.cbbFiltroCategoria.Size = new System.Drawing.Size(92, 21);
            this.cbbFiltroCategoria.TabIndex = 17;
            // 
            // cbbFiltroMarca
            // 
            this.cbbFiltroMarca.FormattingEnabled = true;
            this.cbbFiltroMarca.Location = new System.Drawing.Point(215, 79);
            this.cbbFiltroMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbbFiltroMarca.Name = "cbbFiltroMarca";
            this.cbbFiltroMarca.Size = new System.Drawing.Size(92, 21);
            this.cbbFiltroMarca.TabIndex = 18;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(785, 412);
            this.Controls.Add(this.cbbFiltroMarca);
            this.Controls.Add(this.cbbFiltroCategoria);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.lblMarcas);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblcategorias);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.lblopcion);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 451);
            this.MinimumSize = new System.Drawing.Size(801, 451);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Artículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblopcion;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Label lblcategorias;
      //  private System.Windows.Forms.ComboBox cbbFiltroMarca;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ComboBox cbbFiltroCategoria;
        private System.Windows.Forms.ComboBox cbbFiltroMarca;
    }
}

