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
    public partial class FuncionesTexto : Form
    {
        public FuncionesTexto()
        {
            InitializeComponent();
        }

        private void FuncionesTexto_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LongitudLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            if (cadena.Length == 0) //o if (string.IsNullOrEmpty(cadena))
            {
                MessageBox.Show("Debe ingresar una cadena de caracteres");
                CadenaTextBox.Focus();
                return; //Si detecta que no se ha detectado ningun valor retorna a la instrucción anterior.
            }

            LongitudLabel.Text = cadena.Length.ToString();

            PrimerCaracterLabel.Text = cadena.Substring(0, 1); //0 es la primera posición y primer lugar de busqueda, y 1 la siguiente y ultima posición a buscar.

            UltimoCaracterLabel.Text = cadena.Substring(cadena.Length - 1, 1);

            MayusLabel.Text = cadena.ToUpper();

            MinusLabel.Text = cadena.ToLower();

            RemplazarLabel.Text = cadena.Replace("n", "*"); //Este lenguaje diferencia minusculas de mayusculas.


        }

        //Cuando se teclea la tecla "Enter" por el evento KeyDown.
        private void CadenaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string cadena = CadenaTextBox.Text;

                if (cadena.Length == 0) //o if (string.IsNullOrEmpty(cadena))
                {
                    MessageBox.Show("Debe ingresar una cadena de caracteres");
                    CadenaTextBox.Focus();
                    return; //Si detecta que no se ha detectado ningun valor retorna a la instrucción anterior.
                }

                LongitudLabel.Text = cadena.Length.ToString();

                PrimerCaracterLabel.Text = cadena.Substring(0, 1); //0 es la primera posición y primer lugar de busqueda, y 1 la siguiente y ultima posición a buscar.

                UltimoCaracterLabel.Text = cadena.Substring(cadena.Length - 1, 1);

                MayusLabel.Text = cadena.ToUpper();

                MinusLabel.Text = cadena.ToLower();

                RemplazarLabel.Text = cadena.Replace("n", "*"); //Este lenguaje diferencia minusculas de mayusculas.
            }
        }

        //Para poner en comentarios todo un bloque de codigo apretar Ctrl + K + C. Poner en comentarios tambien
        //la linea de codigo del nombre de formulario.Designer.cs, tambien puede ir directamente a la linea
        //del codigo cuando se presenta el error e ir  al vinculo fijado para ese proposito.

        //private void cadenatextbox_textchanged(object sender, eventargs e) //Este evento de bloque de codigo cambia una cadena por la que el programador elija.
        //{
        //    cadenatextbox.text = cadenatextbox.text.replace("juan", "****");
        //}

        //... Para descomentar un bloque, apretar Ctrl + K + U.

        //Para poner un tipo de "mascara" como si se tratara de un Password (contraseña)
        //nos vamos a las propiedades de la TextBox que querramos ocultar la entrada de
        //valores y nos vamos a la casilla de "PasswordChar" e ingresamos el caracter
        //deseado (* por ejemplo).

    }
}
