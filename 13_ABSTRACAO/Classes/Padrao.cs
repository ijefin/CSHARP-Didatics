using System;

abstract class Padrao
{
    public abstract void taxaEmprestimo(double valor);

    public void taxaPoupanca(double valor, double taxa)
    {
        Console.WriteLine($"Valores obtidos pela poupança: {valor * taxa}");

    }
}