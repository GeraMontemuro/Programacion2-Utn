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
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.rdbagregar = new System.Windows.Forms.RadioButton();
            this.rdbmodificar = new System.Windows.Forms.RadioButton();
            this.rdbeliminar = new System.Windows.Forms.RadioButton();
            this.gbopciones = new System.Windows.Forms.GroupBox();
            this.lblopcion = new System.Windows.Forms.Label();
            this.btnOpcion = new System.Windows.Forms.Button();
            this.btobusqueda = new System.Windows.Forms.Button();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.cbbusqueda = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btndetalle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblcategorias = new System.Windows.Forms.Label();
            this.lblMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbopciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(24, 164);
            this.dgvArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.Size = new System.Drawing.Size(580, 236);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(611, 91);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(264, 287);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // rdbagregar
            // 
            this.rdbagregar.AutoSize = true;
            this.rdbagregar.Location = new System.Drawing.Point(8, 23);
            this.rdbagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbagregar.Name = "rdbagregar";
            this.rdbagregar.Size = new System.Drawing.Size(124, 20);
            this.rdbagregar.TabIndex = 2;
            this.rdbagregar.TabStop = true;
            this.rdbagregar.Text = "Agregar Articulo";
            this.rdbagregar.UseVisualStyleBackColor = true;
            // 
            // rdbmodificar
            // 
            this.rdbmodificar.AutoSize = true;
            this.rdbmodificar.Location = new System.Drawing.Point(149, 23);
            this.rdbmodificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbmodificar.Name = "rdbmodificar";
            this.rdbmodificar.Size = new System.Drawing.Size(130, 20);
            this.rdbmodificar.TabIndex = 3;
            this.rdbmodificar.TabStop = true;
            this.rdbmodificar.Text = "Modificar Articulo";
            this.rdbmodificar.UseVisualStyleBackColor = true;
            // 
            // rdbeliminar
            // 
            this.rdbeliminar.AutoSize = true;
            this.rdbeliminar.Location = new System.Drawing.Point(301, 23);
            this.rdbeliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbeliminar.Name = "rdbeliminar";
            this.rdbeliminar.Size = new System.Drawing.Size(123, 20);
            this.rdbeliminar.TabIndex = 4;
            this.rdbeliminar.TabStop = true;
            this.rdbeliminar.Text = "Eliminar Articulo";
            this.rdbeliminar.UseVisualStyleBackColor = true;
            // 
            // gbopciones
            // 
            this.gbopciones.Controls.Add(this.rdbeliminar);
            this.gbopciones.Controls.Add(this.rdbmodificar);
            this.gbopciones.Controls.Add(this.rdbagregar);
            this.gbopciones.Location = new System.Drawing.Point(24, 418);
            this.gbopciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbopciones.Name = "gbopciones";
            this.gbopciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbopciones.Size = new System.Drawing.Size(439, 62);
            this.gbopciones.TabIndex = 5;
            this.gbopciones.TabStop = false;
            // 
            // lblopcion
            // 
            this.lblopcion.AutoSize = true;
            this.lblopcion.Location = new System.Drawing.Point(20, 404);
            this.lblopcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblopcion.Name = "lblopcion";
            this.lblopcion.Size = new System.Drawing.Size(102, 16);
            this.lblopcion.TabIndex = 6;
            this.lblopcion.Text = "Elija una opcion";
            // 
            // btnOpcion
            // 
            this.btnOpcion.Location = new System.Drawing.Point(24, 492);
            this.btnOpcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.Size = new System.Drawing.Size(164, 30);
            this.btnOpcion.TabIndex = 7;
            this.btnOpcion.Text = "Aceptar";
            this.btnOpcion.UseVisualStyleBackColor = true;
            // 
            // btobusqueda
            // 
            this.btobusqueda.Location = new System.Drawing.Point(413, 29);
            this.btobusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btobusqueda.Name = "btobusqueda";
            this.btobusqueda.Size = new System.Drawing.Size(148, 37);
            this.btobusqueda.TabIndex = 8;
            this.btobusqueda.Text = "Buscar";
            this.btobusqueda.UseVisualStyleBackColor = true;
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(16, 29);
            this.tbbusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(364, 22);
            this.tbbusqueda.TabIndex = 9;
            // 
            // cbbusqueda
            // 
            this.cbbusqueda.FormattingEnabled = true;
            this.cbbusqueda.Location = new System.Drawing.Point(56, 93);
            this.cbbusqueda.Name = "cbbusqueda";
            this.cbbusqueda.Size = new System.Drawing.Size(157, 24);
            this.cbbusqueda.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMarcas);
            this.groupBox1.Controls.Add(this.lblcategorias);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cbbusqueda);
            this.groupBox1.Controls.Add(this.tbbusqueda);
            this.groupBox1.Controls.Add(this.btobusqueda);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 135);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(622, 384);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(227, 35);
            this.btndetalle.TabIndex = 12;
            this.btndetalle.Text = "Listar Detalle";
            this.btndetalle.UseVisualStyleBackColor = true;
            this.btndetalle.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // lblcategorias
            // 
            this.lblcategorias.AutoSize = true;
            this.lblcategorias.Location = new System.Drawing.Point(54, 71);
            this.lblcategorias.Name = "lblcategorias";
            this.lblcategorias.Size = new System.Drawing.Size(73, 16);
            this.lblcategorias.TabIndex = 12;
            this.lblcategorias.Text = "Categorias";
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(292, 70);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(52, 16);
            this.lblMarcas.TabIndex = 13;
            this.lblMarcas.Text = "Marcas";
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(917, 537);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.lblopcion);
            this.Controls.Add(this.gbopciones);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbopciones.ResumeLayout(false);
            this.gbopciones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.RadioButton rdbagregar;
        private System.Windows.Forms.RadioButton rdbmodificar;
        private System.Windows.Forms.RadioButton rdbeliminar;
        private System.Windows.Forms.GroupBox gbopciones;
        private System.Windows.Forms.Label lblopcion;
        private System.Windows.Forms.Button btnOpcion;
        private System.Windows.Forms.Button btobusqueda;
        private System.Windows.Forms.TextBox tbbusqueda;
        private System.Windows.Forms.ComboBox cbbusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Label lblcategorias;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMarcas;
    }
}

