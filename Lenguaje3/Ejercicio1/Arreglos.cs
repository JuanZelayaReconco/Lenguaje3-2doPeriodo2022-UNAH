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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se pueden inicializar vectores de muchas formas.
            int[] vector1 = new int[5];

            vector1[0] = 20;
            vector1[1] = 24;
            vector1[2] = 31;
            vector1[3] = 13;
            vector1[4] = 80; //Recordemos que en cada vector, la primera posición es la 0, se le resta 1 unidad al length (o size) total.

            int[] vector2 = new int[5] {80, 60, 20, 56, 87};

            int[] vector3 = new int[] { 3, 6, 4, 7, 4 };

            int[] vector4 = { 5, 3, 5, 8, 4 };

            String[] vector5 = { "Juan", "Maria", "Carlos", "Sandra" };

            //Ciclo "for" de toda la vida.
            //for (int i = 0; i < vector5.length; i++)
            //{
            //    listbox1.items.add(vector5[i]);
            //}

            //Ciclo "foreach".
            foreach (string item in vector5)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Declarar una matriz.
            //int[,] matriz = new int[2, 3]
            //                            {
            //                                {5,9,4 },{1,6,2}
            //                            };

            int [,] matriz = new int[2, 3];

            //matriz[0, 0] = 5;
            //matriz[0, 1] = 9;
            //matriz[0, 2] = 4;
            //matriz[1, 0] = 1;
            //matriz[1, 1] = 6;
            //matriz[1, 2] = 2;

            ////Llamar una matriz (parte 1).
            //for(int i = 0; i < matriz.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matriz.GetLength(1); j++)
            //    {
            //        listBox2.Items.Add(matriz[i, j]);
            //    }
            //}

            //Llamar una matriz (parte 2).
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 1 + (i + 3) * (j + 1);
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    listBox2.Items.Add("La posición: ["+i+","+j+"] = " + matriz[i,j]);
                }
            }
        }
    }
}
