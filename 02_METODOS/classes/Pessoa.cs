using System;
class Pessoa
{
    public void apresentar()
    {
        Console.WriteLine("Olá, não possuo parâmetros =)");
    }
    public void apresentar(string param)
    {
        Console.WriteLine($"Olá, eu possuo um parametro chamado: {param}");
    }
    public void apresentar(string param, string param2)
    {
        Console.WriteLine($" Aqui eu possuo 2 paramentros, que são: {param} e {param2}");
    }
}