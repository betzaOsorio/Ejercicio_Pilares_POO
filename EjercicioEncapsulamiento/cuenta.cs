/*2.Modifica la clase CuentaBancaria para que tenga:

Un límite de retiro diario.
Un método MostrarSaldo() que indique cuánto queda.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pilares_POO.EjercicioEncapsulamiento
{
    class CuentaBancaria
    {
        private double saldo;
        private double limiteRetiroDiario;
        private double retiroHoy;

        public CuentaBancaria(double saldo)
        {
            this.saldo = saldo;
            limiteRetiroDiario = 3000;
            retiroHoy = 0;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }

        }

        public double LimiteRetiroDiario
        {
            get { return limiteRetiroDiario; }
            set
            {
                if (value >= 0)
                {
                    limiteRetiroDiario = value;
                }
            }

        }

        public double RetiroHoy
        {
            get { return retiroHoy; }
            set
            {
                if (value >= 0 && value <= limiteRetiroDiario)
                {
                    retiroHoy = value;
                }
                else
                {
                    Console.WriteLine("El retiro excede el límite diario o es negativo.");
                }
            }
        }
    }
}

