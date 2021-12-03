namespace CircodeAppsTDS06
{
    partial class Frmcarro
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
            this.lblalcool = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtalcool = new System.Windows.Forms.TextBox();
            this.txtgasolina = new System.Windows.Forms.TextBox();
            this.lblgasolina = new System.Windows.Forms.Label();
            this.txttrecho = new System.Windows.Forms.TextBox();
            this.lbltrecho = new System.Windows.Forms.Label();
            this.txtconsumo = new System.Windows.Forms.TextBox();
            this.lblconsumo = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblcombustivel = new System.Windows.Forms.Label();
            this.lblgasbest = new System.Windows.Forms.Label();
            this.lblgasto = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblalcool
            // 
            this.lblalcool.AutoSize = true;
            this.lblalcool.Location = new System.Drawing.Point(22, 24);
            this.lblalcool.Name = "lblalcool";
            this.lblalcool.Size = new System.Drawing.Size(82, 13);
            this.lblalcool.TabIndex = 0;
            this.lblalcool.Text = "Preço do Alcool";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(297, 46);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 1;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // txtalcool
            // 
            this.txtalcool.Location = new System.Drawing.Point(25, 49);
            this.txtalcool.Name = "txtalcool";
            this.txtalcool.Size = new System.Drawing.Size(100, 20);
            this.txtalcool.TabIndex = 2;
            // 
            // txtgasolina
            // 
            this.txtgasolina.Location = new System.Drawing.Point(25, 118);
            this.txtgasolina.Name = "txtgasolina";
            this.txtgasolina.Size = new System.Drawing.Size(100, 20);
            this.txtgasolina.TabIndex = 4;
            // 
            // lblgasolina
            // 
            this.lblgasolina.AutoSize = true;
            this.lblgasolina.Location = new System.Drawing.Point(22, 93);
            this.lblgasolina.Name = "lblgasolina";
            this.lblgasolina.Size = new System.Drawing.Size(94, 13);
            this.lblgasolina.TabIndex = 3;
            this.lblgasolina.Text = "Preço da Gasolina";
            // 
            // txttrecho
            // 
            this.txttrecho.Location = new System.Drawing.Point(25, 207);
            this.txttrecho.Name = "txttrecho";
            this.txttrecho.Size = new System.Drawing.Size(100, 20);
            this.txttrecho.TabIndex = 6;
            // 
            // lbltrecho
            // 
            this.lbltrecho.AutoSize = true;
            this.lbltrecho.Location = new System.Drawing.Point(22, 182);
            this.lbltrecho.Name = "lbltrecho";
            this.lbltrecho.Size = new System.Drawing.Size(130, 13);
            this.lbltrecho.TabIndex = 5;
            this.lbltrecho.Text = "Distancia a percorrer (KM)";
            // 
            // txtconsumo
            // 
            this.txtconsumo.Location = new System.Drawing.Point(25, 296);
            this.txtconsumo.Name = "txtconsumo";
            this.txtconsumo.Size = new System.Drawing.Size(100, 20);
            this.txtconsumo.TabIndex = 8;
            // 
            // lblconsumo
            // 
            this.lblconsumo.AutoSize = true;
            this.lblconsumo.Location = new System.Drawing.Point(22, 271);
            this.lblconsumo.Name = "lblconsumo";
            this.lblconsumo.Size = new System.Drawing.Size(136, 13);
            this.lblconsumo.TabIndex = 7;
            this.lblconsumo.Text = "Consumo médio por KM / L";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(297, 115);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblcombustivel
            // 
            this.lblcombustivel.AutoSize = true;
            this.lblcombustivel.Location = new System.Drawing.Point(255, 214);
            this.lblcombustivel.Name = "lblcombustivel";
            this.lblcombustivel.Size = new System.Drawing.Size(64, 13);
            this.lblcombustivel.TabIndex = 10;
            this.lblcombustivel.Text = "Combustivel";
            // 
            // lblgasbest
            // 
            this.lblgasbest.AutoSize = true;
            this.lblgasbest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgasbest.Location = new System.Drawing.Point(255, 250);
            this.lblgasbest.Name = "lblgasbest";
            this.lblgasbest.Size = new System.Drawing.Size(66, 24);
            this.lblgasbest.TabIndex = 11;
            this.lblgasbest.Text = "label6";
            // 
            // lblgasto
            // 
            this.lblgasto.AutoSize = true;
            this.lblgasto.Location = new System.Drawing.Point(255, 284);
            this.lblgasto.Name = "lblgasto";
            this.lblgasto.Size = new System.Drawing.Size(85, 13);
            this.lblgasto.TabIndex = 12;
            this.lblgasto.Text = "Gasto Realizado";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(255, 322);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(66, 24);
            this.lblprice.TabIndex = 13;
            this.lblprice.Text = "label8";
            // 
            // Frmcarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 450);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblgasto);
            this.Controls.Add(this.lblgasbest);
            this.Controls.Add(this.lblcombustivel);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtconsumo);
            this.Controls.Add(this.lblconsumo);
            this.Controls.Add(this.txttrecho);
            this.Controls.Add(this.lbltrecho);
            this.Controls.Add(this.txtgasolina);
            this.Controls.Add(this.lblgasolina);
            this.Controls.Add(this.txtalcool);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblalcool);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmcarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de combustivel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblalcool;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtalcool;
        private System.Windows.Forms.TextBox txtgasolina;
        private System.Windows.Forms.Label lblgasolina;
        private System.Windows.Forms.TextBox txttrecho;
        private System.Windows.Forms.Label lbltrecho;
        private System.Windows.Forms.TextBox txtconsumo;
        private System.Windows.Forms.Label lblconsumo;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblcombustivel;
        private System.Windows.Forms.Label lblgasbest;
        private System.Windows.Forms.Label lblgasto;
        private System.Windows.Forms.Label lblprice;
    }
}