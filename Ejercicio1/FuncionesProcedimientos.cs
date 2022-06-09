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
    public partial class FuncionesProcedimientos : Form
    {
        public FuncionesProcedimientos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            int valor1;
            int valor2;

            valor1 = Convert.ToInt32(Valor1textBox.Text);
            valor2 = Convert.ToInt32(Valor2textBox.Text);

            Suma(valor1, valor2);
        }

        private void Restarbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La resta es: "+ Resta(Convert.ToInt32(Valor1textBox.Text), Convert.ToInt32(Valor2textBox.Text)));
        }

        //Procedimiento
        private void Suma(int num1, int num2)
        {
            int suma = num1 + num2;
            MessageBox.Show("La suma es: "+ suma);
        }

        //Función
        private int Resta(int a, int b)
        {
            return a - b;
        }

    }
}
