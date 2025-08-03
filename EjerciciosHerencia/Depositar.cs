using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase_Pilares_POO.EjerciciosHerencia
{
    public class Depositar
    {
        public Depositar()
        {

        class Cuenta
        {
            public double Saldo { get; set; }

            public void Depositar(double cantidad)
            {
                Saldo += cantidad;
                Console.WriteLine("Se depositaron Q" + cantidad + ". Saldo actual: Q" + Saldo);
            }


            public virtual void CalcularIntereses()
            {
                Console.WriteLine("Calculando intereses base...");
            }

            class CuentaAhorro : Cuenta
            {
                public override void CalcularIntereses()
                {
                    double interes = Saldo * 0.05;
                    Console.WriteLine("Interés de ahorro: Q" + interes);
                }
            }

            class CuentaCorriente : Cuenta
            {
                public override void CalcularIntereses()
                {
                    double interes = Saldo * 0.02;
                    Console.WriteLine("Interés de cuenta corriente: Q" + interes);
                }
            }

        }
    }
}


