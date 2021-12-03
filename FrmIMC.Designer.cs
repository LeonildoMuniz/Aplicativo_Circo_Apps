namespace CircodeAppsTDS06
{
    partial class FrmIMC
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.lblpeso = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.lblimc = new System.Windows.Forms.Label();
            this.lblimcresult = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblimcresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(230, 47);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(25, 31);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(83, 13);
            this.lblaltura.TabIndex = 1;
            this.lblaltura.Text = "Digite sua altura";
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(28, 47);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 20);
            this.txtaltura.TabIndex = 2;
            this.txtaltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaltura_KeyPress);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(28, 101);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 3;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpeso_KeyPress);
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(25, 85);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(80, 13);
            this.lblpeso.TabIndex = 3;
            this.lblpeso.Text = "Digite seu peso";
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(230, 98);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Location = new System.Drawing.Point(25, 177);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(48, 13);
            this.lblimc.TabIndex = 6;
            this.lblimc.Text = "Seu IMC";
            // 
            // lblimcresult
            // 
            this.lblimcresult.AutoSize = true;
            this.lblimcresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimcresult.Location = new System.Drawing.Point(25, 232);
            this.lblimcresult.Name = "lblimcresult";
            this.lblimcresult.Size = new System.Drawing.Size(0, 24);
            this.lblimcresult.TabIndex = 7;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(25, 297);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 8;
            this.lblresultado.Text = "Resultado";
            // 
            // lblimcresultado
            // 
            this.lblimcresultado.AutoSize = true;
            this.lblimcresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimcresultado.Location = new System.Drawing.Point(25, 356);
            this.lblimcresultado.Name = "lblimcresultado";
            this.lblimcresultado.Size = new System.Drawing.Size(0, 24);
            this.lblimcresultado.TabIndex = 9;
            // 
            // FrmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.lblimcresultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblimcresult);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.btncalcular);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora do IMC";
            this.Load += new System.EventHandler(this.FrmIMC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.Label lblimcresult;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblimcresultado;
    }
}