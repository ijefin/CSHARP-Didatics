using System;

class Aluno
{
    public string nome;
    public double nota1, nota2;

    public double media()
    {
        return (nota1 + nota2) / 2;
    }

    public string situacao(double media)
    {
        return media > 18 ? "APROVADO" : "REPROVADO";
    }

    public void mensagem()
    {
        double obterMedia = media();

        string obterSituacao = situacao(obterMedia);

        Console.WriteLine($"O aluno {nome} esta em situação de {obterSituacao} com uma média de {obterMedia}");
    }
}