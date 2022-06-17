using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuanZelaya
{
    //UNAH
    //17-06-2022
    //Segundo Periodo - 2022
    //IA086 - Lenguaje de Programación III
    //Examen Primer Parcial
    //Docente: Ing. Nahum Casco Muñoz
    //Alumno: Juan Samuel Zelaya Reconco
    //No. de Cuenta: 20081002433

    public partial class Intereses : Form
    {
        public Intereses()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            InteresListBox.Items.Clear(); //Limpia la listbox en caso que hayan registros previamente.

            //Inicialización de variables.
            double capital = Convert.ToDouble(CapitalTextBox.Text);
            double tasa = (Convert.ToDouble(TasaTextBox.Text)/100);
            DateTime fechaDeposito = dateTimePicker1.Value;
            DateTime fechaPosibleRetiro = dateTimePicker2.Value;

            TimeSpan convertTiempo = fechaPosibleRetiro.Subtract(fechaDeposito); //Esta instrucción sirve para sacar la
                                                                          //diferencia en días entre dos fechas.

            int tiempoMeses=Convert.ToInt32(convertTiempo.Days)/30; //Convertimos los días a meses, basandonos en el
                                                                    //formato de interés comercial (el año consta de
                                                                    //360 días y cada mes se asume que contiene 30 días).

            InteresListBox.Items.Add(tiempoMeses + " meses de generación de intereses: ");
            InteresListBox.Items.Add("...");

            for (int j = 1; j <= tiempoMeses; j++) //Se inicializa "j" en 1 para tomar en consideración
                                                   //que los intereses no se generan el mes en el que
                                                   //fue el depósito, sino hasta el mes siguiente.
            {
                //Se captura el valor almacenado en la variable de la fecha del depósito (fechaDeposito) y se le va
                //aumentar en meses el valor que tenga la variable del control del ciclo, osea "j".
                //El formato "MMMM" en los tipos de archivos "DateTime", nos ayuda a mostrar en pantalla el nombre
                //del mes con respecto al su respectivo número.
                InteresListBox.Items.Add("En "+fechaDeposito.AddMonths(j).ToString("MMMM")+" del "+ 
                                        fechaDeposito.AddMonths(j).Year.ToString() + " generará: " +
                                        "L. "+ CalcularInteres(capital, tasa, j).ToString("N") + " " +
                                        "en intereses.");
            }
            InteresListBox.Items.Add("...");

            capital += CalcularInteres(capital, tasa, tiempoMeses); //Se suman los intereses ganados segun la fecha
                                                                    //del posible retiro al capital inicial.
            InteresListBox.Items.Add("Monto futuro: L. "+capital.ToString("N"));
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Función que nos ayudara a calcular el interes, de manera mensual.
        private double CalcularInteres(double c, double i , double t)
        {
            double _I;

            return _I = c * i * t;
        }
    }
}
