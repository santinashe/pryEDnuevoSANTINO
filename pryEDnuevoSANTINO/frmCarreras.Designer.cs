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
            this.lstCarreras.Location = new System.Drawing.Point(5, 119);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(359, 160);
            this.lstCarreras.TabIndex = 9;
            // 
            // btnGrabarC
            // 
            this.btnGrabarC.Location = new System.Drawing.Point(270, 75);
            this.btnGrabarC.Name = "btnGrabarC";
            this.btnGrabarC.Size = new System.Drawing.Size(94, 38);
            this.btnGrabarC.TabIndex = 8;
            this.btnGrabarC.Text = "Grabar";
            this.btnGrabarC.UseVisualStyleBackColor = true;
            this.btnGrabarC.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCarrera.Location = new System.Drawing.Point(93, 37);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(190, 23);
            this.txtCarrera.TabIndex = 6;
            // 
            // lblnombreC
            // 
            this.lblnombreC.AutoSize = true;
            this.lblnombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreC.Location = new System.Drawing.Point(133, 9);
            this.lblnombreC.Name = "lblnombreC";
            this.lblnombreC.Size = new System.Drawing.Size(85, 25);
            this.lblnombreC.TabIndex = 5;
            this.lblnombreC.Text = "Carrera";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(21, 75);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 38);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(138, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 38);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Limpiar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 354);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.btnGrabarC);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.lblnombreC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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