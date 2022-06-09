using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class Perro
    {
        //Atributos.
        private string nombre;
        private string raza;
        private decimal altura;

        //Propiedades (se pueden usar propiedades directamente sin declarar atributos).
            //Manera "normal".
        //public string nombre 
        //{ 
        //    get { return nombre; } 
        //    set { nombre = value; } 
        //}

        //public string raza
        //{
        //    get { return raza; }
        //    set { raza = value; }
        //}

        //public decimal altura 
        //{
        //    get { return altura; }
        //    set { altura = value; }
        //}

            //Manera usando el comando "prop" y apretar la tecla "tap" dos veces.
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public decimal Altura { get; set; }

        //Constructores.
        public Perro()
        {
            //Constructor vacio (muy utiles).
        }

            //O también podemos crear un constructor mandandole argumentos.
        //public Perro(string _nombre, string _raza, decimal _altura)
        //{
        //    nombre = _nombre;
        //    raza = _raza;
        //    altura = _altura;
        //}

            //También Podemos generar un método constructor con el icono del destornillador (o foco).
        public Perro(string nombre, string raza, decimal altura)
        {
            Nombre = nombre;
            Raza = raza;
            Altura = altura;
        }

            ////Podemos usar "Sobrecarga".
        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        //Métodos.
        public string DevuelveNombre()
        {
            return Nombre;
        }

        public string Comer(string comida)
        {
            return Nombre + " comerá " + comida;
        }
    }
}
