namespace pryEDnuevoSANTINO
{
    partial class frmCarreras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarreras));
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.btnGrabarC = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.lblnombreC = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.ItemHeight = 16;
            this.lstCarreras.Location = new System.Drawing.Point(7, 146);
            this.lstCarreras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(477, 196);
            this.lstCarreras.TabIndex = 9;
            // 
            // btnGrabarC
            // 
            this.btnGrabarC.Location = new System.Drawing.Point(360, 92);
            this.btnGrabarC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabarC.Name = "btnGrabarC";
            this.btnGrabarC.Size = new System.Drawing.Size(125, 47);
            this.btnGrabarC.TabIndex = 8;
            this.btnGrabarC.Text = "Grabar";
            this.btnGrabarC.UseVisualStyleBackColor = true;
            this.btnGrabarC.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCarrera.Location = new System.Drawing.Point(124, 46);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(252, 26);
            this.txtCarrera.TabIndex = 6;
            // 
            // lblnombreC
            // 
            this.lblnombreC.AutoSize = true;
            this.lblnombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreC.Location = new System.Drawing.Point(177, 11);
            this.lblnombreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombreC.Name = "lblnombreC";
            this.lblnombreC.Size = new System.Drawing.Size(104, 29);
            this.lblnombreC.TabIndex = 5;
            this.lblnombreC.Text = "Carrera";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(28, 92);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(125, 47);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(184, 351);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 47);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Limpiar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryEDnuevoSANTINO.Properties.Resources.Gemini_Generated_Image_frr8q3frr8q3frr81;
            this.ClientSize = new System.Drawing.Size(501, 436);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.btnGrabarC);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblnombreC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCarrera";
            this.Load += new System.EventHandler(this.frmCarreras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Button btnGrabarC;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblnombreC;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnEliminar;
    }
}