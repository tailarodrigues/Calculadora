using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calcauladora
{
    public partial class Form1 : Form
    {
        double Total;
        double UltimoNumero;
        string operador;

        private void Limpar() 
        {
            Total = 0;
            UltimoNumero = 0;
            operador = "+";
            mtbResultado.Text = "0";     
                    
        }

        private void Calcular()
        {

            switch (operador)
            {
                case "+": Total = Total + UltimoNumero;
                    break;
                case "-": Total = Total - UltimoNumero;
                    break;
                case "X": Total = Total * UltimoNumero;
                    break;
                case "/": Total = Total / UltimoNumero;
                    break;
            }

            UltimoNumero = 0;
            mtbResultado.Text = Total.ToString();

        }


        public Form1()
        {
            InitializeComponent();

            Limpar();

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Operacao(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

            Calcular();

            operador = (sender as Button).Text;

        }

        private void btNumero(object sender, EventArgs e)
        { 
            if (UltimoNumero == 0)
            {
                mtbResultado.Text = (sender as Button).Text;
            } 
            else
            {
                mtbResultado.Text = mtbResultado.Text + (sender as Button).Text;
                
             }

            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);

            Calcular();

            operador = "+";

            Total = 0;
        }

    }
}
