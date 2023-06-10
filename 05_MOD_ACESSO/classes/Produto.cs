class Produto
{
    //Pode ter os atributos e métodos acessados por qualquer classe
    public string nome;

    //Pode ter os atributos e métodos acessados apenas pela classe no qual foi definido
    private double preco = 5000;

    // Pode ter os atributos e métodos acessados pela classe no qual foi definido e pelas sublcasses.
    private double desconto = 50.524;

    public void mostraDados()
    {
        Console.WriteLine($"{nome}, {preco}, {desconto}");
    }
}