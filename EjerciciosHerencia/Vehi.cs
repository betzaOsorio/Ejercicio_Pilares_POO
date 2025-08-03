using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pilares_POO.EjerciciosHerencia
{
    public class Vehi
    {
        class Vehiculo
        {
            public string Marca { get; set; }

            public void Avanzar()
            {
                Console.WriteLine(Marca + " está avanzando.");
            }
        }

        class Auto : Vehiculo
        {
            public void EncenderRadio()
            {
                Console.WriteLine(Marca + " está encendiendo la radio.");
            }
        }

        class Motocicleta : Vehiculo
        {
            public void HacerCaballito()
            {
                Console.WriteLine(Marca + " está haciendo un caballito.");
            }
        }
    }
}
