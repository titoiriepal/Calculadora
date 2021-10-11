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
        private char operador;
        private char igualOperador;
        private byte numOperandos;
        private double operando1;
        private double operando2;
       
        public Form1()
        {
            InitializeComponent();
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            igualOperador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
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
            Button objButton = (Button)sender;
            string textoBoton = objButton.Text;
            ;
            if (ultimaEntrada == Entrada.DIGITO)
                numOperandos += 1;
            if (numOperandos == 1)
            {
                igualOperador = textoBoton[0];
                operando1 = double.Parse(etPantalla.Text);
            }
            else if (numOperandos == 2)
            {
                operando2 = double.Parse(etPantalla.Text);
                switch (operador)
                {
                    case '+':
                        operando1 += operando2;
                        break;
                    case '-':
                        operando1 -= operando2;
                        break;
                    case 'x':
                        operando1 *= operando2;
                        break;
                    case '/':
                        operando1 /= operando2;
                        break;
                    case '=':
                        operando1 = operando2;
                        break;
                }
                etPantalla.Text = operando1.ToString();

                numOperandos = 1;
            }
            operador = textoBoton[0];
            ultimaEntrada = Entrada.OPERADOR;
            
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

        private void btIgual_Click(object sender, EventArgs e)
        {

        }
    }
}
