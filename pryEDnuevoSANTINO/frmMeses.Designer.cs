namespace pryEDnuevoSANTINO
{
    partial class frmMeses
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
            this.LstColoresM = new System.Windows.Forms.ListBox();
            this.btnGrabarM = new System.Windows.Forms.Button();
            this.btnListarM = new System.Windows.Forms.Button();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblnombreM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstColoresM
            // 
            this.LstColoresM.FormattingEnabled = true;
            this.LstColoresM.Location = new System.Drawing.Point(12, 172);
            this.LstColoresM.Name = "LstColoresM";
            this.LstColoresM.Size = new System.Drawing.Size(359, 160);
            this.LstColoresM.TabIndex = 9;
            // 
            // btnGrabarM
            // 
            this.btnGrabarM.Location = new System.Drawing.Point(201, 88);
            this.btnGrabarM.Name = "btnGrabarM";
            this.btnGrabarM.Size = new System.Drawing.Size(94, 38);
            this.btnGrabarM.TabIndex = 8;
            this.btnGrabarM.Text = "Grabar";
            this.btnGrabarM.UseVisualStyleBackColor = true;
            this.btnGrabarM.Click += new System.EventHandler(this.btnGrabarM_Click);
            // 
            // btnListarM
            // 
            this.btnListarM.Location = new System.Drawing.Point(12, 88);
            this.btnListarM.Name = "btnListarM";
            this.btnListarM.Size = new System.Drawing.Size(94, 38);
            this.btnListarM.TabIndex = 7;
            this.btnListarM.Text = "Listar";
            this.btnListarM.UseVisualStyleBackColor = true;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombreM.Location = new System.Drawing.Point(105, 28);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(190, 23);
            this.txtNombreM.TabIndex = 6;
            // 
            // lblnombreM
            // 
            this.lblnombreM.AutoSize = true;
            this.lblnombreM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombreM.Location = new System.Drawing.Point(12, 24);
            this.lblnombreM.Name = "lblnombreM";
            this.lblnombreM.Size = new System.Drawing.Size(87, 25);
            this.lblnombreM.TabIndex = 5;
            this.lblnombreM.Text = "Nombre";
            // 
            // frmMeses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.LstColoresM);
            this.Controls.Add(this.btnGrabarM);
            this.Controls.Add(this.btnListarM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.lblnombreM);
            this.Name = "frmMeses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMeses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstColoresM;
        private System.Windows.Forms.Button btnGrabarM;
        private System.Windows.Forms.Button btnListarM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lblnombreM;
    }
}