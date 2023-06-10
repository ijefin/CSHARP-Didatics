using System;

class Aluno
{
    public double nota1, nota2;

    private double media()
    {
        return nota1 + nota2 / 2;
    }

    public void mensagem()
    {
        Console.WriteLine("Digite a PRIMEIRA nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a SEGUNDA nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine($"A média é {media()}.");
    }
}