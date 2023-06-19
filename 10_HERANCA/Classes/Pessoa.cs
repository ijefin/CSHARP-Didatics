using System;
class Pessoa
{
    protected string nome, endereco, profissao;
    protected int idade;
    protected void dadosPessoa()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Endereco: {endereco}");
        Console.WriteLine($"Profissao: {profissao}");
    }
}