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
        private byte numOperandos;
        private double operando1;
        private double operando2;
       
        public Form1()
        {
            InitializeComponent();
            btIniciar.PerformClick();
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
                txtPantalla.Text = " ";
                ultimaEntrada = Entrada.DIGITO;
                comaDecimal = false;
            }
            txtPantalla.Text += objButton.Text;
        }

        private void BtOperation_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "-") return;
            Button objButton = (Button)sender;
            string textoBoton = objButton.Text;

            if (ultimaEntrada == Entrada.DIGITO)
                numOperandos += 1;
            if (numOperandos == 1)
            {
                operando1 = double.Parse(txtPantalla.Text);
            }
            else if (numOperandos == 2)
            {
                operando2 = double.Parse(txtPantalla.Text);
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
            txtPantalla.Text = operando1.ToString();
            numOperandos = 1;
            }
            operador = textoBoton[0];
            ultimaEntrada = Entrada.OPERADOR;


        }

        private void btComaDec_Click(object sender, EventArgs e)
        {
            if (ultimaEntrada != Entrada.DIGITO)
            {
                txtPantalla.Text = "0,";
                ultimaEntrada = Entrada.DIGITO;
            }
            else if (comaDecimal == false)
                txtPantalla.Text = txtPantalla.Text + ",";
            comaDecimal = true;
        }

        private void btTantoPorCiento_Click(object sender, EventArgs e)
        {
            double resultado;
            
            if (ultimaEntrada == Entrada.DIGITO)
            {
                resultado = operando1 * double.Parse(txtPantalla.Text) / 100;
                txtPantalla.Text = resultado.ToString();
                btIgual.PerformClick();
                btTantoPorCiento.Focus();
            }
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0,";
            ultimaEntrada = Entrada.NINGUNA;
            comaDecimal = false;
            operador = '\0';
            numOperandos = 0;
            operando1 = 0;
            operando2 = 0;
        }

        private void btBorrarEntrada_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0,";
            ultimaEntrada = Entrada.CE;
            comaDecimal = false;
        }

        private void btMasMenos_Click_1(object sender, EventArgs e)
        {
            double numero = (double.Parse(txtPantalla.Text) * -1);
            txtPantalla.Text = numero.ToString();
        }

        private void txtPantalla_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(8)) e.Handled = false;
            else if (e.KeyChar == ',')
            {
                TextBox ObjTextBox = (TextBox)sender;
                if (ObjTextBox.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void txtPantalla_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
