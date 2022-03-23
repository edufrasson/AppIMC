using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Calcular_IMC(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(valor_peso.Text);
            double altura = Convert.ToDouble(valor_altura.Text);

            double imc = peso / (altura * altura);
            string msg_tabela;

            if (imc < 18.5)
            {
                msg_tabela = "Abaixo do peso normal";
            }
            else if (imc >= 18.5 && imc < 25)
            { // operador and = &&
                msg_tabela = "Peso normal";
            }
            else if (imc >= 25 && imc < 30)
            {
                msg_tabela = "Excesso de peso";
            }
            else if (imc >= 30 && imc < 35)
            {
                msg_tabela = "Obesidade classe I";
            }
            else if (imc >= 35 && imc < 40)
            {
                msg_tabela = "Obesidade classe II";
            }
            else
            {
                msg_tabela = "Obesidade classe III";
            }

            string msg_completa = string.Format("Seu IMC é {0} \n {1}", imc.ToString("F2"), msg_tabela);

            DisplayAlert("Resultado", msg_completa, "Fechar");
        }
    }
}

