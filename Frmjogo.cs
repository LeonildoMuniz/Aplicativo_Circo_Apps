using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircodeApp3
{
    public partial class Frmjogo : Form
    {
        public Frmjogo()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cbxopcao_SelectedIndexChanged(object sender, EventArgs e)
        {
           int opcao = cbxopcao.SelectedIndex;
            
            switch (opcao)
            {
                case 0:
                    pbxopcao.Image = Properties.Resources.papel;
                break;
                case 1:
                    pbxopcao.Image = Properties.Resources.pedra;
                break;
                case 2:
                    pbxopcao.Image = Properties.Resources.tesoura;
                break;
            }
        }

        private void btnjogar_Click(object sender, EventArgs e)
        {
            int opcao = cbxopcao.SelectedIndex;
            Random randonum = new Random();
            int sorteio = Convert.ToInt32(randonum.Next(3));
            switch (sorteio)
            {
                case 0:
                    pbxjogo.Image = Properties.Resources.papel;
                break;
                case 1:
                    pbxjogo.Image = Properties.Resources.pedra;
                break;
                case 2:
                    pbxjogo.Image = Properties.Resources.tesoura;
                break;
            }
            if (opcao==0 && sorteio==1 || opcao==1 && sorteio==2 || opcao==2 && sorteio==0)
            {
                MessageBox.Show("Você ganhou!!!", "Ganhou :D", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
            }
            else if (sorteio==0 && opcao==1 || sorteio==1 && opcao==2 || sorteio==2 && opcao==0)
            {
                MessageBox.Show("Você Perdeu","Perdeu :(",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Empate!!", "Empatou :/", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        
    }
}
