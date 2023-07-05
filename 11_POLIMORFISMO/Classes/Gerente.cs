using System;
class Gerente : Imposto
{

    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine($"Desconto GERENTE: {salario * 0.15}");
    }

    public override void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto GERENTE: {salario * 0.15}");
    }
}