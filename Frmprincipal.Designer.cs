namespace CircoDeAPP
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbuscacep = new System.Windows.Forms.Label();
            this.pbxCEP = new System.Windows.Forms.PictureBox();
            this.btnsair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbuscacep
            // 
            this.lblbuscacep.AutoSize = true;
            this.lblbuscacep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscacep.Location = new System.Drawing.Point(47, 175);
            this.lblbuscacep.Name = "lblbuscacep";
            this.lblbuscacep.Size = new System.Drawing.Size(85, 16);
            this.lblbuscacep.TabIndex = 0;
            this.lblbuscacep.Text = "Busca CEP";
            this.lblbuscacep.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbxCEP
            // 
            this.pbxCEP.Image = global::CircoDeAPP.Properties.Resources.cep;
            this.pbxCEP.Location = new System.Drawing.Point(12, 12);
            this.pbxCEP.Name = "pbxCEP";
            this.pbxCEP.Size = new System.Drawing.Size(157, 160);
            this.pbxCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCEP.TabIndex = 1;
            this.pbxCEP.TabStop = false;
            this.pbxCEP.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(723, 437);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(85, 42);
            this.btnsair.TabIndex = 2;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.pbxCEP);
            this.Controls.Add(this.lblbuscacep);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps TDS06";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscacep;
        private System.Windows.Forms.PictureBox pbxCEP;
        private System.Windows.Forms.Button btnsair;
    }
}

