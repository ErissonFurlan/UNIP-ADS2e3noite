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

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Executor(String op)
        {
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
            
            if (controle.mensagem.Equals (""))
            {
                lblResultado.Text = controle.resposta;
            }
            else
            {
                MessageBox.Show(controle.mensagem);
                txbPrimeiroNumero.Clear();
                txbSegundoNumero.Clear();
                lblResultado.Text = "Resultado";
                txbPrimeiroNumero.Focus();
            }
        }



        private void btnSomar_Click(object sender, EventArgs e)
        {
            Executor("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Executor ("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Executor("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Executor("/");
        }

        
       
    }
}
