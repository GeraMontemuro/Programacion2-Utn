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
            this.lblopcion = new System.Windows.Forms.Label();
            this.btobusqueda = new System.Windows.Forms.Button();
            this.tbbusqueda = new System.Windows.Forms.TextBox();
            this.cbbusqueda = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMarcas = new System.Windows.Forms.Label();
            this.lblcategorias = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btndetalle = new System.Windows.Forms.Button();
            this.btnArticulo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(18, 133);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.Size = new System.Drawing.Size(435, 192);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(458, 74);
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
            // btobusqueda
            // 
            this.btobusqueda.Location = new System.Drawing.Point(310, 24);
            this.btobusqueda.Name = "btobusqueda";
            this.btobusqueda.Size = new System.Drawing.Size(111, 30);
            this.btobusqueda.TabIndex = 8;
            this.btobusqueda.Text = "Buscar";
            this.btobusqueda.UseVisualStyleBackColor = true;
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(12, 24);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(274, 20);
            this.tbbusqueda.TabIndex = 9;
            // 
            // cbbusqueda
            // 
            this.cbbusqueda.FormattingEnabled = true;
            this.cbbusqueda.Location = new System.Drawing.Point(42, 76);
            this.cbbusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.cbbusqueda.Name = "cbbusqueda";
            this.cbbusqueda.Size = new System.Drawing.Size(119, 21);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(427, 110);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lblMarcas
            // 
            this.lblMarcas.AutoSize = true;
            this.lblMarcas.Location = new System.Drawing.Point(219, 57);
            this.lblMarcas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcas.Name = "lblMarcas";
            this.lblMarcas.Size = new System.Drawing.Size(42, 13);
            this.lblMarcas.TabIndex = 13;
            this.lblMarcas.Text = "Marcas";
            // 
            // lblcategorias
            // 
            this.lblcategorias.AutoSize = true;
            this.lblcategorias.Location = new System.Drawing.Point(40, 58);
            this.lblcategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcategorias.Name = "lblcategorias";
            this.lblcategorias.Size = new System.Drawing.Size(57, 13);
            this.lblcategorias.TabIndex = 12;
            this.lblcategorias.Text = "Categorias";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(200, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // btndetalle
            // 
            this.btndetalle.Location = new System.Drawing.Point(466, 312);
            this.btndetalle.Margin = new System.Windows.Forms.Padding(2);
            this.btndetalle.Name = "btndetalle";
            this.btndetalle.Size = new System.Drawing.Size(170, 28);
            this.btndetalle.TabIndex = 12;
            this.btndetalle.Text = "Listar Detalle";
            this.btndetalle.UseVisualStyleBackColor = true;
            // 
            // btnArticulo
            // 
            this.btnArticulo.Location = new System.Drawing.Point(18, 374);
            this.btnArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.btnArticulo.Name = "btnArticulo";
            this.btnArticulo.Size = new System.Drawing.Size(94, 24);
            this.btnArticulo.TabIndex = 13;
            this.btnArticulo.Text = "Agregar Artículo";
            this.btnArticulo.UseVisualStyleBackColor = true;
            this.btnArticulo.Click += new System.EventHandler(this.btnArticulo_Click);
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
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 436);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnArticulo);
            this.Controls.Add(this.btndetalle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblopcion);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblopcion;
        private System.Windows.Forms.Button btobusqueda;
        private System.Windows.Forms.TextBox tbbusqueda;
        private System.Windows.Forms.ComboBox cbbusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btndetalle;
        private System.Windows.Forms.Label lblcategorias;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMarcas;
        private System.Windows.Forms.Button btnArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

