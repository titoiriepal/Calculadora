using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private enum Entrada
        {
            NINGUNA,
            DIGITO,
            OPERADOR,
            CE
        }

        private Entrada ultimaEntrada;
        private bool comaDecimal;
        public Form1()
        {
            InitializeComponent();
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
        }

        private void bt7n_MouseHover(object sender, EventArgs e)
        {
            return;
        }

        private void BtDigito_Click(object sender, EventArgs e)
        {
            Button objButton = (Button)sender;
            if (ultimaEntrada != Entrada.DIGITO)
            {
                if (objButton.Text == "0") return;
                etPantalla.Text = "";
                ultimaEntrada = Entrada.DIGITO;
                comaDecimal = false;
            }
            etPantalla.Text += objButton.Text;
        }

        private void BtOperation_Click(object sender, EventArgs e)
        {

        }

        private void btComaDec_Click(object sender, EventArgs e)
        {
            if (ultimaEntrada != Entrada.DIGITO)
            {
                etPantalla.Text = "0,";
                ultimaEntrada = Entrada.DIGITO;
            }
            else if (comaDecimal == false)
                etPantalla.Text = etPantalla.Text + ",";
            comaDecimal = true;
        }
    }
}
