using System;
class Atendente : Imposto
{
    public override void valeAlimentacao(double salario)
    {
        System.Console.WriteLine($"Desconto VA ATENDENTE: {salario * 0.12}");
    }

    public override void valeTransporte(double salario)
    {
        Console.WriteLine($"Desconto VT ATENDENTE: {salario * 0.13}");
    }
}