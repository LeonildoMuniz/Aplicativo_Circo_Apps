namespace CircodeApp3
{
    partial class Frmjogo
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
            this.btnjogar = new System.Windows.Forms.Button();
            this.cbxopcao = new System.Windows.Forms.ComboBox();
            this.lblopcao = new System.Windows.Forms.Label();
            this.pbxopcao = new System.Windows.Forms.PictureBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.pbxjogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxopcao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxjogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnjogar
            // 
            this.btnjogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogar.Location = new System.Drawing.Point(343, 34);
            this.btnjogar.Name = "btnjogar";
            this.btnjogar.Size = new System.Drawing.Size(75, 23);
            this.btnjogar.TabIndex = 0;
            this.btnjogar.Text = "Jogar";
            this.btnjogar.UseVisualStyleBackColor = true;
            this.btnjogar.Click += new System.EventHandler(this.btnjogar_Click);
            // 
            // cbxopcao
            // 
            this.cbxopcao.FormattingEnabled = true;
            this.cbxopcao.Items.AddRange(new object[] {
            "Papel",
            "Pedra",
            "Tesoura"});
            this.cbxopcao.Location = new System.Drawing.Point(31, 36);
            this.cbxopcao.Name = "cbxopcao";
            this.cbxopcao.Size = new System.Drawing.Size(249, 21);
            this.cbxopcao.TabIndex = 1;
            this.cbxopcao.SelectedIndexChanged += new System.EventHandler(this.cbxopcao_SelectedIndexChanged);
            // 
            // lblopcao
            // 
            this.lblopcao.AutoSize = true;
            this.lblopcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblopcao.Location = new System.Drawing.Point(28, 20);
            this.lblopcao.Name = "lblopcao";
            this.lblopcao.Size = new System.Drawing.Size(129, 13);
            this.lblopcao.TabIndex = 2;
            this.lblopcao.Text = "Selecione uma opção";
            // 
            // pbxopcao
            // 
            this.pbxopcao.Image = global::CircodeApp3.Properties.Resources.pedrapapeltesoura1;
            this.pbxopcao.Location = new System.Drawing.Point(31, 131);
            this.pbxopcao.Name = "pbxopcao";
            this.pbxopcao.Size = new System.Drawing.Size(249, 226);
            this.pbxopcao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxopcao.TabIndex = 3;
            this.pbxopcao.TabStop = false;
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(517, 34);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // pbxjogo
            // 
            this.pbxjogo.Image = global::CircodeApp3.Properties.Resources.pedrapapeltesoura1;
            this.pbxjogo.Location = new System.Drawing.Point(343, 131);
            this.pbxjogo.Name = "pbxjogo";
            this.pbxjogo.Size = new System.Drawing.Size(249, 226);
            this.pbxjogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxjogo.TabIndex = 5;
            this.pbxjogo.TabStop = false;
            // 
            // Frmjogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 401);
            this.Controls.Add(this.pbxjogo);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.pbxopcao);
            this.Controls.Add(this.lblopcao);
            this.Controls.Add(this.cbxopcao);
            this.Controls.Add(this.btnjogar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmjogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedra Papel e Tesoura";
            ((System.ComponentModel.ISupportInitialize)(this.pbxopcao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxjogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnjogar;
        private System.Windows.Forms.ComboBox cbxopcao;
        private System.Windows.Forms.Label lblopcao;
        private System.Windows.Forms.PictureBox pbxopcao;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.PictureBox pbxjogo;
    }
}