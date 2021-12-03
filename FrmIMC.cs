using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeAppsTDS06
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmIMC_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtaltura;
            txtaltura.Focus();
        }

        private void txtaltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void txtpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            if (txtaltura.Text == "" || txtpeso.Text == "")
            {
                MessageBox.Show("Não há calculos sem valores! Por favor digite os campos altura e peso!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                altura = Convert.ToDouble(txtaltura.Text);
                peso = Convert.ToDouble(txtpeso.Text);
                resultado = peso / (altura * altura);
                lblimcresult.Text = resultado.ToString("F");
                txtaltura.Text = "";
                txtpeso.Text = "";

                if (resultado<=18.5)
                {
                    lblimcresultado.Text = "Peso abaixo do normal";
                    MessageBox.Show("Procure um médico risco de alto de morte!", "Perigo!!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado>18.5 && resultado<=25)
                {
                    lblimcresultado.Text = "Peso Normal";
                }
                else if (resultado>25 && resultado<=30)
                {
                    lblimcresultado.Text = "Sobrepeso";
                }
                else if (resultado>30 && resultado<=35)
                {
                    lblimcresultado.Text = "Obesidade (Grau 1)";
                }
                else if (resultado>35 && resultado<=40)
                {
                    lblimcresultado.Text = "Obesidade Severa (Grau 2)";
                }
                else 
                {
                    lblimcresultado.Text = "Obesidade Mórbida (Grau 3)";
                    MessageBox.Show("Procure um médico risco de alto de morte!","Perigo!!!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }

        }
    }
}
