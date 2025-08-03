using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*3.Diseña una clase Vehiculo con métodos para Encender() y Apagar(), y una propiedad
Encendido que sea true o false, controlada internamente.*/


namespace Clase_ejercicio.EjercicioEncapsulamiento
{
    internal class Vehiculo
    {
        private bool encendido;
        private bool apagado;
        public bool Encendido
        {
            get { return encendido; }
            private set { encendido = value; }

        }

        public void Encender()
        {
            if (!encendido)
            {
                encendido = true;
                Console.WriteLine("El vehiculo ta encendido.");
            }
        }

        public void Apagar()
        {
            if (encendido)
            {
                encendido = false;
                Console.WriteLine("El vehiculo ta apagado");
            }
        }

    }
}
