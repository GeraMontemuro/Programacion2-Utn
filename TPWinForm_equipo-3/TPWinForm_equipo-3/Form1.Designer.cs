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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbopciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.Location = new System.Drawing.Point(18, 115);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 51;
            this.dgvArticulo.Size = new System.Drawing.Size(435, 192);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(458, 74);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(198, 233);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 1;
            this.pbxArticulo.TabStop = false;
            // 
            // rdbagregar
            // 
            this.rdbagregar.AutoSize = true;
            this.rdbagregar.Location = new System.Drawing.Point(6, 19);
            this.rdbagregar.Name = "rdbagregar";
            this.rdbagregar.Size = new System.Drawing.Size(100, 17);
            this.rdbagregar.TabIndex = 2;
            this.rdbagregar.TabStop = true;
            this.rdbagregar.Text = "Agregar Articulo";
            this.rdbagregar.UseVisualStyleBackColor = true;
            // 
            // rdbmodificar
            // 
            this.rdbmodificar.AutoSize = true;
            this.rdbmodificar.Location = new System.Drawing.Point(112, 19);
            this.rdbmodificar.Name = "rdbmodificar";
            this.rdbmodificar.Size = new System.Drawing.Size(106, 17);
            this.rdbmodificar.TabIndex = 3;
            this.rdbmodificar.TabStop = true;
            this.rdbmodificar.Text = "Modificar Articulo";
            this.rdbmodificar.UseVisualStyleBackColor = true;
            // 
            // rdbeliminar
            // 
            this.rdbeliminar.AutoSize = true;
            this.rdbeliminar.Location = new System.Drawing.Point(226, 19);
            this.rdbeliminar.Name = "rdbeliminar";
            this.rdbeliminar.Size = new System.Drawing.Size(99, 17);
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
            this.gbopciones.Location = new System.Drawing.Point(18, 340);
            this.gbopciones.Name = "gbopciones";
            this.gbopciones.Size = new System.Drawing.Size(329, 50);
            this.gbopciones.TabIndex = 5;
            this.gbopciones.TabStop = false;
            // 
            // lblopcion
            // 
            this.lblopcion.AutoSize = true;
            this.lblopcion.Location = new System.Drawing.Point(15, 328);
            this.lblopcion.Name = "lblopcion";
            this.lblopcion.Size = new System.Drawing.Size(82, 13);
            this.lblopcion.TabIndex = 6;
            this.lblopcion.Text = "Elija una opcion";
            // 
            // btnOpcion
            // 
            this.btnOpcion.Location = new System.Drawing.Point(18, 400);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.Size = new System.Drawing.Size(123, 24);
            this.btnOpcion.TabIndex = 7;
            this.btnOpcion.Text = "Aceptar";
            this.btnOpcion.UseVisualStyleBackColor = true;
            // 
            // btobusqueda
            // 
            this.btobusqueda.Location = new System.Drawing.Point(315, 37);
            this.btobusqueda.Name = "btobusqueda";
            this.btobusqueda.Size = new System.Drawing.Size(111, 30);
            this.btobusqueda.TabIndex = 8;
            this.btobusqueda.Text = "Buscar";
            this.btobusqueda.UseVisualStyleBackColor = true;
            // 
            // tbbusqueda
            // 
            this.tbbusqueda.Location = new System.Drawing.Point(18, 47);
            this.tbbusqueda.Name = "tbbusqueda";
            this.tbbusqueda.Size = new System.Drawing.Size(274, 20);
            this.tbbusqueda.TabIndex = 9;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 436);
            this.Controls.Add(this.tbbusqueda);
            this.Controls.Add(this.btobusqueda);
            this.Controls.Add(this.btnOpcion);
            this.Controls.Add(this.lblopcion);
            this.Controls.Add(this.gbopciones);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulo);
            this.Name = "frmListado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listame";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbopciones.ResumeLayout(false);
            this.gbopciones.PerformLayout();
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
    }
}

