using Clase_Pilares_POO.EjercicioEncapsulamiento;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Empleado empleado = new Empleado();

        empleado.Nombre = "Betza";
        empleado.Salario = 8000;
        Console.WriteLine("Nombre empleado: " + empleado.Nombre);
        Console.WriteLine("Salario empleado: " + empleado.Salario);

        CuentaBancaria cuenta = new CuentaBancaria(5000);
        cuenta.LimiteRetiroDiario = 3000;
        cuenta.RetiroHoy = 5000;
        Console.WriteLine("Saldo cuenta: " + cuenta.Saldo);
        Console.WriteLine("Límite de retiro diario: " + cuenta.LimiteRetiroDiario);
        Console.WriteLine("Retiro hoy: " + cuenta.RetiroHoy);

        Vehiculo vehiculo = new Vehiculo();
        vehiculo.Encender();
        vehiculo.Apagar();
        Console.WriteLine("Vehículo encendido: " + vehiculo.Encendido);
        Console.WriteLine("Vehículo apagado: " + !vehiculo.Encendido);


    }
}
