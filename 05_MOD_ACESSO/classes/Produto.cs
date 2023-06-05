class Produto
{
    //Atributos e métodos visiveis em qualquer classe
    public string nome;

    //Atributos e métodos visíveis apenas na classe que foi criada
    private double valor = 5000;

    //Atributos e métodos visíveis em classes onde são criados ou herdados
    protected int data;

    public void mostraNome()
    {
        Console.WriteLine($"{nome}, valor: {valor}");
    }

}