using Clase_Pilares_POO.EjerciciosHerencia;
using System;

internal class Progra
{
    private static void Main(string[] args)
    {

        Gerente g = new Gerente();
        g.Nombre = "Bet";
        g.Salario = 12000;
        g.TomarDecision();

        Desarrollador d = new Desarrollador();
        d.Nombre = "Carlos";
        d.Salario = 7000;
        d.Programar();

        Auto miAuto = new Auto();
        miAuto.Marca = "Mercedes - Benz";
        miAuto.Avanzar();
        miAuto.EncenderRadio();

        Motocicleta miMoto = new Motocicleta();
        miMoto.Marca = "Suzuki";
        miMoto.Avanzar();
        miMoto.HacerCaballito();

        CuentaAhorro ahorro = new CuentaAhorro();
        ahorro.Depositar(1000);
        ahorro.CalcularIntereses();

        Console.WriteLine();

        CuentaCorriente corriente = new CuentaCorriente();
        corriente.Depositar(1000);
        corriente.CalcularIntereses();

    }
}
