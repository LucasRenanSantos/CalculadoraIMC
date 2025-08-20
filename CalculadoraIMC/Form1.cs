using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Peso = double.Parse(txbPeso.Text);
            double Altura = double.Parse(txbAltura.Text);
           

            if(Peso <= 0)
            {
                MessageBox.Show("O peso deve ser maior que zero!");
                
            }
            else if (Altura <= 0) 
            {
                MessageBox.Show("A altura deve ser maior que zero!");
            }
            else
            {
                double IMC = Peso / (Altura * Altura);

                string classificacao;

                if (IMC < 18.5)
                    classificacao = "Abaixo do peso";
                else if (IMC < 25)
                    classificacao = "Peso normal";
                else if (IMC < 30)
                    classificacao = "Sobrepeso";
                else if (IMC < 35)
                    classificacao = "Obesidade grau 1";
                else if (IMC < 40)
                    classificacao = "Obesidade grau 2";
                else
                    classificacao = "Obesidade grau 3";

                lblSeuIMC.Text = $"IMC: {IMC:F2} - {classificacao}";
            }
        }

    }
}
    
