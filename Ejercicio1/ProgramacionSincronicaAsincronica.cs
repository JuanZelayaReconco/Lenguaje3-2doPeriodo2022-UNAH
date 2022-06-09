using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class ProgramacionSincronicaAsincronica : Form
    {
        public ProgramacionSincronicaAsincronica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Horneando una pizza...";
            HornearPizza();
            label1.Text = "Proceso Terminado!";
        }

        //Procedimiento Síncrono.
        private void HornearPizza()
        {
            System.Threading.Thread.Sleep(10000); //Hace una espera de 10,000 milisegundo o 10 segundos, congelando la ventana en el transcurso.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Horneando una pizza...";
            HornearPizzaAsync();
            label4.Text = "Proceso Terminado!";
        }

        //Procedimiento Asíncronico.
        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000); //Hace la misma espera de 10 segundos, solo que sin congelar la ventana.
        }

        private async void SumarButton_Click(object sender, EventArgs e)
        {
            if (Numero1TextBox.Text.Length == 0 || Numero2TextBox.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar ambos números para realizar este proceso.", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Numero1TextBox.Focus();
                return;
            }

            decimal numero1 = Convert.ToDecimal(Numero1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Numero2TextBox.Text);

            decimal resultado = await SumarAsync(numero1, numero2);

            MessageBox.Show("La suma es: " + resultado.ToString(), "Suma Asíncronica");
        }

        //Otra función asíncronica.
        private async Task <Decimal> SumarAsync(decimal num1, decimal num2)
        {
            decimal suma = await Task.Run(() =>
            {
                return num1 + num2;
            });
            return suma;
        }
    }
}
