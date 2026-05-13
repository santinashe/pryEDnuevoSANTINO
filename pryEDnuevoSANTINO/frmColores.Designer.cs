namespace pryEDnuevoSANTINO
{
    partial class frmColores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColores));
            this.lblnombreC = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnListarC = new System.Windows.Forms.Button();
            this.btnGrabarC = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombreC
            // 
            this.lblnombreC.AutoSize = true;
            this.lblnombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreC.Location = new System.Drawing.Point(200, 11);
            this.lblnombreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombreC.Name = "lblnombreC";
            this.lblnombreC.Size = new System.Drawing.Size(109, 29);
            this.lblnombreC.TabIndex = 0;
            this.lblnombreC.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.Location = new System.Drawing.Point(132, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnListarC
            // 
            this.btnListarC.Location = new System.Drawing.Point(51, 102);
            this.btnListarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListarC.Name = "btnListarC";
            this.btnListarC.Size = new System.Drawing.Size(125, 47);
            this.btnListarC.TabIndex = 2;
            this.btnListarC.Text = "Listar";
            this.btnListarC.UseVisualStyleBackColor = true;
            this.btnListarC.Click += new System.EventHandler(this.btnListarC_Click);
            // 
            // btnGrabarC
            // 
            this.btnGrabarC.Location = new System.Drawing.Point(345, 102);
            this.btnGrabarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabarC.Name = "btnGrabarC";
            this.btnGrabarC.Size = new System.Drawing.Size(125, 47);
            this.btnGrabarC.TabIndex = 3;
            this.btnGrabarC.Text = "Grabar";
            this.btnGrabarC.UseVisualStyleBackColor = true;
            this.btnGrabarC.Click += new System.EventHandler(this.btnGrabarC_Click);
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.ItemHeight = 16;
            this.lstColores.Location = new System.Drawing.Point(19, 171);
            this.lstColores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(477, 196);
            this.lstColores.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(424, 395);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(72, 27);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDnuevoSANTINO.Properties.Resources.Gemini_Generated_Image_frr8q3frr8q3frr81;
            this.ClientSize = new System.Drawing.Size(537, 507);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.btnGrabarC);
            this.Controls.Add(this.btnListarC);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblnombreC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Colores";
            this.Load += new System.EventHandler(this.frmColores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnListarC;
        private System.Windows.Forms.Button btnGrabarC;
        private System.Windows.Forms.ListBox lstColores;
        private System.Windows.Forms.Button btnLimpiar;
    }
}