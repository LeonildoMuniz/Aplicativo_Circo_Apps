﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxCEP_Click(object sender, EventArgs e)
        {
            FrmBuscaCEP busca = new FrmBuscaCEP();
            busca.Show();
        }

        private void pbxJogo_Click(object sender, EventArgs e)
        {
            FrmJogo jogo = new FrmJogo();
            jogo.Show();
        }

        private void pcximc_Click(object sender, EventArgs e)
        {
            FrmIMC imc = new FrmIMC();
            imc.Show();
             
        }

        private void pbxcarro_Click(object sender, EventArgs e)
        {
            Frmcarro carro = new Frmcarro();
            carro.Show();
        }
    }
}
