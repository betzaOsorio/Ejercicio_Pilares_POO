using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Crea una clase Empleado con atributos privados nombre y salario. 
 * Usa propiedades para
que:
El nombre no se pueda dejar en blanco.
El salario no sea negativo.*/




namespace Clase_Pilares_POO.EjercicioEncapsulamiento
{
    class Empleado
    {
        private string nombre;
        private double salario;

        public string Nombre
        {
            get { return nombre; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;

                }
            }
        }
        public double Salario
        {
            get { return salario; }
            set
            {
                if (value >= 0)
                {
                    salario = value;
                }
            }
        }
    }
}