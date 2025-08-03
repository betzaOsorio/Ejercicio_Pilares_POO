using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Crea una clase Empleado con propiedades Nombre y Salario. Luego crea:
Una clase Gerente que tenga un método TomarDecision().
Una clase Desarrollador con método Programar().*/

namespace Clase_Pilares_POO.EjerciciosHerencia
{

    public class Empleado
    {
        public string Nombre { get; set; }
        public double Salario { get; set; }
    }

    public class Gerente : Empleado
    {
        public void TomarDecision()
        {
            Console.WriteLine(Nombre + " está tomando decisiones.");
        }
    }

    public class Desarrollador : Empleado
    {
        public void Programar()
        {
            Console.WriteLine(Nombre + " está programando el código.");
        }
    }
}