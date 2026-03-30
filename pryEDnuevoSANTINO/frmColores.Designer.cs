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
            this.lblnombreC = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.btnListarC = new System.Windows.Forms.Button();
            this.btnGrabarC = new System.Windows.Forms.Button();
            this.LstColores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblnombreC
            // 
            this.lblnombreC.AutoSize = true;
            this.lblnombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreC.Location = new System.Drawing.Point(23, 57);
            this.lblnombreC.Name = "lblnombreC";
            this.lblnombreC.Size = new System.Drawing.Size(87, 25);
            this.lblnombreC.TabIndex = 0;
            this.lblnombreC.Text = "Nombre";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreC.Location = new System.Drawing.Point(116, 63);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(190, 23);
            this.txtNombreC.TabIndex = 1;
            // 
            // btnListarC
            // 
            this.btnListarC.Location = new System.Drawing.Point(86, 122);
            this.btnListarC.Name = "btnListarC";
            this.btnListarC.Size = new System.Drawing.Size(94, 38);
            this.btnListarC.TabIndex = 2;
            this.btnListarC.Text = "Listar";
            this.btnListarC.UseVisualStyleBackColor = true;
            // 
            // btnGrabarC
            // 
            this.btnGrabarC.Location = new System.Drawing.Point(268, 122);
            this.btnGrabarC.Name = "btnGrabarC";
            this.btnGrabarC.Size = new System.Drawing.Size(94, 38);
            this.btnGrabarC.TabIndex = 3;
            this.btnGrabarC.Text = "Grabar";
            this.btnGrabarC.UseVisualStyleBackColor = true;
            this.btnGrabarC.Click += new System.EventHandler(this.btnGrabarC_Click);
            // 
            // LstColores
            // 
            this.LstColores.FormattingEnabled = true;
            this.LstColores.Location = new System.Drawing.Point(15, 201);
            this.LstColores.Name = "LstColores";
            this.LstColores.Size = new System.Drawing.Size(359, 160);
            this.LstColores.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 412);
            this.Controls.Add(this.LstColores);
            this.Controls.Add(this.btnGrabarC);
            this.Controls.Add(this.btnListarC);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lblnombreC);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombreC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.Button btnListarC;
        private System.Windows.Forms.Button btnGrabarC;
        private System.Windows.Forms.ListBox LstColores;
    }
}