﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PrimeiraAula.Modelo;

namespace PrimeiraAula
{
    public partial class frmPrincipal : Form
    {
        Controle controle = new Controle();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = controle.Calcular(txbPrimeiroNumero.Text,
                txbSegundoNumero.Text, "+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            lblResultado.Text = controle.Calcular(txbPrimeiroNumero.Text,
                txbSegundoNumero.Text, "-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = controle.Calcular(txbPrimeiroNumero.Text,
                txbSegundoNumero.Text, "*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            lblResultado.Text = controle.Calcular(txbPrimeiroNumero.Text,
                txbSegundoNumero.Text, "/");
        }

        
       
    }
}
