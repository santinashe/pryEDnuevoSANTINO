namespace pryEDnuevoSANTINO
{
    partial class frmGrafo
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
            this.btnOrigenes = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnCagar = new System.Windows.Forms.Button();
            this.mskPrecio2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDestino2 = new System.Windows.Forms.ComboBox();
            this.cmbOrigen2 = new System.Windows.Forms.ComboBox();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cordoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.mskPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gbConsultadedatos = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.gbListado.SuspendLayout();
            this.gbCargaDatos.SuspendLayout();
            this.gbConsultadedatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrigenes
            // 
            this.btnOrigenes.Location = new System.Drawing.Point(460, 13);
            this.btnOrigenes.Name = "btnOrigenes";
            this.btnOrigenes.Size = new System.Drawing.Size(113, 23);
            this.btnOrigenes.TabIndex = 46;
            this.btnOrigenes.Text = "Listar Origenes";
            this.btnOrigenes.UseVisualStyleBackColor = true;
            this.btnOrigenes.Click += new System.EventHandler(this.btnOrigenes_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(295, 20);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 44;
            this.lblHasta.Text = "Hasta:";
            // 
            // btnCagar
            // 
            this.btnCagar.Location = new System.Drawing.Point(121, 111);
            this.btnCagar.Name = "btnCagar";
            this.btnCagar.Size = new System.Drawing.Size(99, 34);
            this.btnCagar.TabIndex = 26;
            this.btnCagar.Text = "Cargar";
            this.btnCagar.UseVisualStyleBackColor = true;
            this.btnCagar.Click += new System.EventHandler(this.btnCagar_Click);
            // 
            // mskPrecio2
            // 
            this.mskPrecio2.Location = new System.Drawing.Point(72, 78);
            this.mskPrecio2.Mask = "9999999999999";
            this.mskPrecio2.Name = "mskPrecio2";
            this.mskPrecio2.Size = new System.Drawing.Size(156, 20);
            this.mskPrecio2.TabIndex = 25;
            this.mskPrecio2.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Destino:";
            // 
            // cmbDestino2
            // 
            this.cmbDestino2.FormattingEnabled = true;
            this.cmbDestino2.Location = new System.Drawing.Point(72, 44);
            this.cmbDestino2.Name = "cmbDestino2";
            this.cmbDestino2.Size = new System.Drawing.Size(156, 21);
            this.cmbDestino2.TabIndex = 22;
            // 
            // cmbOrigen2
            // 
            this.cmbOrigen2.FormattingEnabled = true;
            this.cmbOrigen2.Location = new System.Drawing.Point(72, 14);
            this.cmbOrigen2.Name = "cmbOrigen2";
            this.cmbOrigen2.Size = new System.Drawing.Size(156, 21);
            this.cmbOrigen2.TabIndex = 20;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(346, 15);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(97, 21);
            this.cmbHasta.TabIndex = 45;
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(160, 15);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(113, 23);
            this.btnDestinos.TabIndex = 43;
            this.btnDestinos.Text = "Listar Destinos";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 18;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.Cordoba,
            this.Mendoza,
            this.SantaFe,
            this.BuenosAires,
            this.Salta});
            this.dgvGrafo.Location = new System.Drawing.Point(6, 46);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersVisible = false;
            this.dgvGrafo.RowHeadersWidth = 51;
            this.dgvGrafo.Size = new System.Drawing.Size(742, 213);
            this.dgvGrafo.TabIndex = 8;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 60;
            // 
            // Cordoba
            // 
            this.Cordoba.Frozen = true;
            this.Cordoba.HeaderText = "Cordoba";
            this.Cordoba.MinimumWidth = 6;
            this.Cordoba.Name = "Cordoba";
            this.Cordoba.Width = 125;
            // 
            // Mendoza
            // 
            this.Mendoza.Frozen = true;
            this.Mendoza.HeaderText = "Mendoza";
            this.Mendoza.MinimumWidth = 6;
            this.Mendoza.Name = "Mendoza";
            this.Mendoza.Width = 125;
            // 
            // SantaFe
            // 
            this.SantaFe.HeaderText = "Santa Fe";
            this.SantaFe.Name = "SantaFe";
            // 
            // BuenosAires
            // 
            this.BuenosAires.HeaderText = "Buenos Aires";
            this.BuenosAires.Name = "BuenosAires";
            // 
            // Salta
            // 
            this.Salta.HeaderText = "Salta";
            this.Salta.Name = "Salta";
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(57, 17);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(97, 21);
            this.cmbDesde.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Origen:";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.btnVerViajes);
            this.gbListado.Controls.Add(this.btnOrigenes);
            this.gbListado.Controls.Add(this.cmbHasta);
            this.gbListado.Controls.Add(this.lblHasta);
            this.gbListado.Controls.Add(this.btnDestinos);
            this.gbListado.Controls.Add(this.cmbDesde);
            this.gbListado.Controls.Add(this.lblDesde);
            this.gbListado.Controls.Add(this.dgvGrafo);
            this.gbListado.Location = new System.Drawing.Point(25, 173);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(754, 265);
            this.gbListado.TabIndex = 43;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listar Viajes";
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(588, 13);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(113, 23);
            this.btnVerViajes.TabIndex = 47;
            this.btnVerViajes.Text = "Ver todos los viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            this.btnVerViajes.Click += new System.EventHandler(this.btnVerViajes_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(16, 111);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(99, 34);
            this.btnBorrarTodo.TabIndex = 19;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.btnCagar);
            this.gbCargaDatos.Controls.Add(this.mskPrecio2);
            this.gbCargaDatos.Controls.Add(this.label1);
            this.gbCargaDatos.Controls.Add(this.label2);
            this.gbCargaDatos.Controls.Add(this.cmbDestino2);
            this.gbCargaDatos.Controls.Add(this.cmbOrigen2);
            this.gbCargaDatos.Controls.Add(this.label3);
            this.gbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gbCargaDatos.Location = new System.Drawing.Point(278, 13);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Size = new System.Drawing.Size(234, 155);
            this.gbCargaDatos.TabIndex = 44;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = " Caga de Datos";
            // 
            // mskPrecio
            // 
            this.mskPrecio.Location = new System.Drawing.Point(65, 81);
            this.mskPrecio.Mask = "9999999999999";
            this.mskPrecio.Name = "mskPrecio";
            this.mskPrecio.Size = new System.Drawing.Size(184, 20);
            this.mskPrecio.TabIndex = 17;
            this.mskPrecio.ValidatingType = typeof(int);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 84);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 51);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 15;
            this.lblDestino.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(65, 47);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(184, 21);
            this.cmbDestino.TabIndex = 14;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(131, 116);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(116, 34);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(65, 17);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(184, 21);
            this.cmbOrigen.TabIndex = 12;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 22);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 9;
            this.lblOrigen.Text = "Origen:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(9, 116);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(116, 34);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gbConsultadedatos
            // 
            this.gbConsultadedatos.Controls.Add(this.mskPrecio);
            this.gbConsultadedatos.Controls.Add(this.lblPrecio);
            this.gbConsultadedatos.Controls.Add(this.lblDestino);
            this.gbConsultadedatos.Controls.Add(this.cmbDestino);
            this.gbConsultadedatos.Controls.Add(this.btnBorrar);
            this.gbConsultadedatos.Controls.Add(this.cmbOrigen);
            this.gbConsultadedatos.Controls.Add(this.lblOrigen);
            this.gbConsultadedatos.Controls.Add(this.btnConsultar);
            this.gbConsultadedatos.Location = new System.Drawing.Point(518, 13);
            this.gbConsultadedatos.Name = "gbConsultadedatos";
            this.gbConsultadedatos.Size = new System.Drawing.Size(255, 155);
            this.gbConsultadedatos.TabIndex = 45;
            this.gbConsultadedatos.TabStop = false;
            this.gbConsultadedatos.Text = "Consulta de datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDnuevoSANTINO.Properties.Resources.pusocla;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbCargaDatos);
            this.Controls.Add(this.gbConsultadedatos);
            this.Name = "frmGrafo";
            this.Text = "frmGrafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.gbConsultadedatos.ResumeLayout(false);
            this.gbConsultadedatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrigenes;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button btnCagar;
        private System.Windows.Forms.MaskedTextBox mskPrecio2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDestino2;
        private System.Windows.Forms.ComboBox cmbOrigen2;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cordoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn SantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salta;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.MaskedTextBox mskPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gbConsultadedatos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}