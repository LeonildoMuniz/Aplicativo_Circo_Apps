
namespace CircodeAppsTDS06
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
            this.lblCEP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPedraPapelTesoura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxcarro = new System.Windows.Forms.PictureBox();
            this.pcximc = new System.Windows.Forms.PictureBox();
            this.pbxJogo = new System.Windows.Forms.PictureBox();
            this.pbxCEP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxcarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcximc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(67, 155);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(70, 13);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "Busca CEP";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(543, 332);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 42);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPedraPapelTesoura
            // 
            this.lblPedraPapelTesoura.AutoSize = true;
            this.lblPedraPapelTesoura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedraPapelTesoura.Location = new System.Drawing.Point(201, 155);
            this.lblPedraPapelTesoura.Name = "lblPedraPapelTesoura";
            this.lblPedraPapelTesoura.Size = new System.Drawing.Size(142, 13);
            this.lblPedraPapelTesoura.TabIndex = 3;
            this.lblPedraPapelTesoura.Text = "Pedra - Papel - Tesoura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calcular IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Calculadora de combustivel";
            // 
            // pbxcarro
            // 
            this.pbxcarro.Image = global::CircodeAppsTDS06.Properties.Resources.gas;
            this.pbxcarro.Location = new System.Drawing.Point(32, 188);
            this.pbxcarro.Name = "pbxcarro";
            this.pbxcarro.Size = new System.Drawing.Size(143, 141);
            this.pbxcarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxcarro.TabIndex = 7;
            this.pbxcarro.TabStop = false;
            this.pbxcarro.Click += new System.EventHandler(this.pbxcarro_Click);
            // 
            // pcximc
            // 
            this.pcximc.Image = global::CircodeAppsTDS06.Properties.Resources.imc;
            this.pcximc.Location = new System.Drawing.Point(369, 11);
            this.pcximc.Name = "pcximc";
            this.pcximc.Size = new System.Drawing.Size(143, 141);
            this.pcximc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcximc.TabIndex = 5;
            this.pcximc.TabStop = false;
            this.pcximc.Click += new System.EventHandler(this.pcximc_Click);
            // 
            // pbxJogo
            // 
            this.pbxJogo.Image = global::CircodeAppsTDS06.Properties.Resources.pedrapapeltesoura1;
            this.pbxJogo.Location = new System.Drawing.Point(200, 11);
            this.pbxJogo.Name = "pbxJogo";
            this.pbxJogo.Size = new System.Drawing.Size(143, 141);
            this.pbxJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxJogo.TabIndex = 4;
            this.pbxJogo.TabStop = false;
            this.pbxJogo.Click += new System.EventHandler(this.pbxJogo_Click);
            // 
            // pbxCEP
            // 
            this.pbxCEP.Image = global::CircodeAppsTDS06.Properties.Resources.cep;
            this.pbxCEP.Location = new System.Drawing.Point(32, 11);
            this.pbxCEP.Name = "pbxCEP";
            this.pbxCEP.Size = new System.Drawing.Size(143, 141);
            this.pbxCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCEP.TabIndex = 1;
            this.pbxCEP.TabStop = false;
            this.pbxCEP.Click += new System.EventHandler(this.pbxCEP_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbxcarro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcximc);
            this.Controls.Add(this.pbxJogo);
            this.Controls.Add(this.lblPedraPapelTesoura);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pbxCEP);
            this.Controls.Add(this.lblCEP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circo de Apps";
            ((System.ComponentModel.ISupportInitialize)(this.pbxcarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcximc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.PictureBox pbxCEP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbxJogo;
        private System.Windows.Forms.Label lblPedraPapelTesoura;
        private System.Windows.Forms.PictureBox pcximc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxcarro;
    }
}

