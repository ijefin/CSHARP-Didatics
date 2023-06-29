using System;
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Executei o construtor na instanciação da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

}