class Colaborador : Pessoa
{
    private double salario;
    private string setor, cargo;

    public Colaborador(string nome, int idade, string endereco, string profissao, double salario, string setor, string cargo)
    {
        this.nome = nome;
        this.idade = idade;
        this.endereco = endereco;
        this.profissao = profissao;
        this.salario = salario;
        this.setor = setor;
        this.cargo = cargo;

        dadosPessoa();
        dadosColaborador();
    }

    private void dadosColaborador()
    {
        Console.WriteLine($"Salário: {salario}");
        Console.WriteLine($"Setor: {setor}");
        Console.WriteLine($"Cargo: {cargo}");
    }

}